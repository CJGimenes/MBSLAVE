Imports System.Threading
Imports System.Deployment.Application
Imports System.Security
Imports System.IO
Imports System.Text

Public Class Porta_Serial

    Dim cont_erro_geral As Long = 0
    Dim cont_erro_time_out As Long = 0
    Dim cont_erro_endereco As Long = 0
    Dim cont_erro_crc As Long = 0
    Dim cont_transacoes As Long = 0
    Dim time_out_read As Integer = 100

    Dim modbus_transacao As Byte

    Dim seq_estado_com As Byte = 0
    Dim numero_registros As Byte
    Dim flag_desconect_request As Boolean = False
    Dim cont_erro As Byte = 0
    Dim cont_com As Byte = 0
    Dim num_reg As Byte = 0
    Dim ini_reg As Byte = 0
    Dim teste_reg As Byte = 0
    Dim flag_frame As Boolean = False
    Dim cont_teste As Byte = 0



    Public Sub Main()
        While 1

            If spModBus.IsOpen Then
                If Timer_frame.Enabled = False Then

                    If spModBus.BytesToRead > 0 Then

                        Timer_frame.Enabled = True
                    End If
                End If
            End If


        End While
    End Sub




    Private Sub Porta_Serial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializa()
        Registros.Inicializa()
        Timer_frame.Enabled = True

    End Sub


    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim count_num_um_frame As Byte
        Dim tabela_endereco As UShort



        If Timer_frame.Enabled = False Then

            If spModBus.IsOpen Then

                endereco = Val(cb_Endereco.Text)

                If flag_desconect_request = True Then
                    flag_desconect_request = False
                    conec_flag = False
                    bt_Conect.BackColor = Color.Tomato


                    If spModBus.IsOpen = True Then
                        spModBus.Close()
                    End If
                    Timer1.Enabled = False
                    flag_link = 0
                    estado_link = 0
                    Registros.Sem_Comunicacao()


                ElseIf comando_escrita <> cmdEscrita.Parado Then

                    Select Case comando_escrita
                        Case cmdEscrita.botaoEnvia

                            count_num_um_frame = 0
                            tabela_endereco = ponteiro_um * NUM_REG_COMANDO
                            Do While count_num_um_frame < 3 And (ponteiro_um <= final_um)
                                ' Registros.monta_tx_um(ponteiro_um, (count_num_um_frame * NUM_REG_COMANDO))
                                count_num_um_frame += 1
                                ponteiro_um += 1
                            Loop

                            ModBus_Write_Mult_Register(endereco, (INI_TAB_COMANDO + tabela_endereco), (count_num_um_frame * NUM_REG_COMANDO), Tuvalues)


                        Case cmdEscrita.escritaSimples
                            ModBus_Write_Register(endereco, escritaSimplesEndereco, escritaSimplesValor)
                    End Select


                Else
                    Select Case seq_estado_com
                        Case 0
                            If num_ums > 16 Then
                                num_reg = 16 * NUM_REG_LEITURA
                            Else
                                num_reg = num_ums * NUM_REG_LEITURA
                            End If
                            ini_reg = INI_TAB_LEITURA
                            ModBus_Read_Register(4, endereco, ini_reg, num_reg, values)

                        Case 1
                            num_reg = (num_ums - 16) * NUM_REG_LEITURA
                            ini_reg = INI_TAB_LEITURA + (16 * NUM_REG_LEITURA)
                            ModBus_Read_Register(4, endereco, ini_reg, num_reg, values)

                    End Select

                End If



            Else

                estado_link = 0

                Registros.Sem_Comunicacao()

            End If
        End If

    End Sub




    Public Sub Inicializa()



        If (ApplicationDeployment.IsNetworkDeployed) Then

            LB_versao.Text = "Versão: " & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4)

        Else
            LB_versao.Text = "Versão: Debug"
        End If


        AtualizaPorta()
        conec_flag = False
        bt_Conect.BackColor = Color.Tomato

        cb_Endereco.SelectedIndex = 1




        Me.Show()
        Me.Select()
        Me.Focus()



    End Sub

    Public Sub ini_simulador()





    End Sub
    Public Sub AtualizaPorta()

        ComboBox_AvailableSerialPorts.Items.Clear()

        For Each AvailableSerialPorts As String In IO.Ports.SerialPort.GetPortNames()

            ComboBox_AvailableSerialPorts.Items.Add(AvailableSerialPorts)
            ComboBox_AvailableSerialPorts.Text = AvailableSerialPorts
            'spModBus.ReadTimeout = 2000
        Next



    End Sub

    Public Sub bt_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Sair.Click

        Dim result As DialogResult

        result = MessageBox.Show("Encerrar a Aplicação?", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If (result = 1) Then
            Application.Exit()
        End If

    End Sub


    Public Sub bt_at_port_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_at_port.Click
        AtualizaPorta()
    End Sub

    Public Function ModBus_Write_Mult_Register(ByVal address As Byte, ByVal ini_register As UShort, ByVal numero As UShort, ByRef values As UShort())


        Dim flag As Boolean
        'Ensure port is open:
        If (spModBus.IsOpen) Then

            'Clear in/out buffers:
            spModBus.DiscardOutBuffer()
            spModBus.DiscardInBuffer()

            'Function 16 request is always 8 bytes:
            Dim message As Byte() = New Byte(8 + (2 * numero)) {}
            Dim response As Byte() = New Byte(7) {}
            Dim CRC As UShort
            'Build outgoing modbus message

            message(0) = Byte.Parse(address)            'Endereço
            message(1) = 16                             'Função               
            message(2) = Byte.Parse(ini_register >> 8)  'Endereço Inicial Hi
            message(3) = Byte.Parse(ini_register And &HFF)       'Endereço Inicial Lo
            message(4) = Byte.Parse(numero >> 8)        'Numero de registros Hi
            message(5) = Byte.Parse(numero And &HFF)    'Numero de registros Lo
            message(6) = 2 * numero                     'Byte Count

            For var = 0 To numero Step 1
                message((var * 2) + 7) = Byte.Parse((values(var) >> 8 And &HFF))
                message((var * 2) + 8) = Byte.Parse((values(var)) And &HFF)
            Next

            CRC = getCRC16(message) 'crc com bytes invertidos

            message(7 + (2 * numero)) = Byte.Parse(CRC And &HFF) 'CRC(1)
            message(8 + (2 * numero)) = Byte.Parse(CRC >> 8) 'CRC(0)

            'Send modbus message to Serial Port:
            Try
                spModBus.Write(message, 0, message.Length)
                'Evaluate message:
                'If (Get_Response_Write()) Then
                '    flag = True
                'End If
                modbus_transacao = 0
                Timer_frame.Interval = time_out_read
                Timer_frame.Enabled = True
                flag = True
            Catch err As Exception
                modbusStatus = "Error: " + err.Message
                flag = False
            End Try
        Else

            modbusStatus = "Not open"
            flag = False
        End If

        If flag = True Then
            modbusStatus = ""
        End If

        Return flag

    End Function

    Public Function ModBus_Write_Register(ByVal address As Byte, ByVal register As UShort, ByVal value As UShort)


        Dim flag As Boolean
        'Ensure port is open:
        If (spModBus.IsOpen) Then

            'Clear in/out buffers:
            spModBus.DiscardOutBuffer()
            spModBus.DiscardInBuffer()
            'Function 6 request is always 8 bytes:
            Dim message As Byte() = New Byte(7) {}
            Dim response As Byte() = New Byte(7) {}
            Dim CRC As UShort
            'Build outgoing modbus message

            message(0) = Byte.Parse(address)
            message(1) = 6
            message(2) = Byte.Parse((register >> 8) And &HFF)
            message(3) = Byte.Parse(register And &HFF)
            message(4) = Byte.Parse(value >> 8)
            message(5) = Byte.Parse(value And &HFF)


            CRC = getCRC16(message) 'crc com bytes invertidos

            message(6) = Byte.Parse(CRC And &HFF) 'CRC(1)
            message(7) = Byte.Parse(CRC >> 8) 'CRC(0)

            'Send modbus message to Serial Port:
            Try
                spModBus.Write(message, 0, message.Length)
                'Evaluate message:
                'If (Get_Response_Write()) Then
                '    flag = True
                'End If
                modbus_transacao = 0
                Timer_frame.Interval = time_out_read
                Timer_frame.Enabled = True
                flag = True
            Catch err As Exception
                modbusStatus = "Error: " + err.Message
                flag = False
            End Try
        Else

            modbusStatus = "Not open"
            flag = False
        End If

        If flag = True Then
            modbusStatus = ""
        End If

        Return flag

    End Function

    Public Function Get_Response_Write()
        Dim CRC_R As UShort
        Dim i As Integer = 0
        Dim response As Byte() = New Byte(7) {}

        'Thread.Sleep(time_out_read)
        If spModBus.BytesToRead < 2 Then
            cont_erro_time_out += 1
            Return False
        Else
            While (spModBus.BytesToRead <> 0)
                response(i) = Byte.Parse(spModBus.ReadByte())
                'Thread.Sleep(1)
                i += 1
                'Application.DoEvents()
            End While


            CRC_R = getCRC16(response) 'crc com bytes invertidos

            If (response(response.Length - 2) = Byte.Parse(CRC_R And &HFF)) And (response(response.Length - 1) = Byte.Parse(CRC_R >> 8)) Then
                Return True
            Else
                cont_erro_crc += 1
                Return False

            End If
        End If

    End Function

    Public Function ModBus_Read_Register(ByVal type As Byte, ByVal address As Byte, ByVal start As UShort, ByVal registers As UShort, ByRef values As Short())

        Dim flag As Boolean
        'Ensure port is open:
        If (spModBus.IsOpen) Then

            'Clear in/out buffers:
            spModBus.DiscardOutBuffer()
            spModBus.DiscardInBuffer()
            'Function 3 request is always 8 bytes:
            Dim message As Byte() = New Byte(7) {}
            'Function 3 response buffer:
            'Dim response As Byte() = New Byte((5 + 2 * registers) - 1) {}
            'Build outgoing modbus message
            Build_Message_Read(address, type, start, registers, message)
            'Send modbus message to Serial Port:
            Try

                spModBus.Write(message, 0, message.Length)
                'Evaluate message:
                'If (Get_Response_Read(response, values)) Then
                '    flag = True
                'End If
                numero_registros = registers
                modbus_transacao = 1
                Timer_frame.Interval = time_out_read
                Timer_frame.Enabled = True
                flag = True
            Catch err As Exception
                modbusStatus = "Error: " + err.Message
                flag = False
            End Try
        Else

            modbusStatus = "Not open"
            flag = False
        End If

        If flag = True Then
            modbusStatus = ""
        End If

        Return flag

    End Function

    Public Sub Build_Message_Read(ByVal address As Byte, ByVal type As Byte, ByVal start As UShort, ByVal registers As Short, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort


        message(0) = Byte.Parse(address)
        message(1) = Byte.Parse(type)
        message(2) = Byte.Parse(start >> 8)
        message(3) = Byte.Parse(start And &HFF)
        message(4) = Byte.Parse(registers >> 8)
        message(5) = Byte.Parse(registers)


        CRC = getCRC16(message) 'crc com bytes invertidos

        message(6) = Byte.Parse(CRC And &HFF) 'CRC(1)
        message(7) = Byte.Parse(CRC >> 8) 'CRC(0)


        ' CRC16 01 03 00 01 00 0A = 94 0D
    End Sub

    Public Function Get_Response_Read(ByRef response As Byte(), ByRef values As Short())

        Dim i As Integer = 0
        Dim CRC_R As UShort

        'Thread.Sleep(time_out_read)
        If spModBus.BytesToRead < 2 Then
            cont_erro_time_out += 1
            Return False
        Else
            While (spModBus.BytesToRead <> 0 And i < response.Length)
                response(i) = Byte.Parse(spModBus.ReadByte())
                'Thread.Sleep(1)
                i += 1
                'Application.DoEvents()
            End While

            'Verifico il messaggio


            CRC_R = getCRC16(response) 'crc com bytes invertidos

            If (response(response.Length - 2) = Byte.Parse(CRC_R And &HFF)) And (response(response.Length - 1) = Byte.Parse(CRC_R >> 8)) Then


                'Ritorno il valore dei registri richiesti
                For i = 0 To ((response.Length - 5) / 2) - 1

                    values(i) = response(2 * i + 3)
                    values(i) <<= 8
                    values(i) += response(2 * i + 4)

                    Uvalues(i) = response(2 * i + 3)
                    Uvalues(i) <<= 8
                    Uvalues(i) += response(2 * i + 4)

                Next

                Return True

            Else
                cont_erro_crc += 1
                Return False

            End If
        End If

    End Function

    Public Function getCRC16(ByRef message As Byte())
        '//Processa uma mensagem recebida e retorna o seu crc16
        '//Entradas:
        '//*msg -> ponteiro para a mensagem a ser processada
        '//size -> tamanho da mensagem a ser processada
        '//Saida:
        '//Retorna o crc16 calculado na ordem reversa

        Dim size As UInteger
        Dim cont As UInteger
        Dim crc_reg As UInteger

        '//1o. passo:
        '//carregar o registro do CRC com 0xFFFF;
        crc_reg = &HFFFF
        size = message.Length - 2
        cont = 0


        While (size)
            crc_reg = crc16_byte(message(cont), crc_reg)
            size -= 1
            cont += 1
        End While

        'size = crc_reg.abyte.msb;
        'crc_reg.abyte.msb = crc_reg.abyte.lsb;
        'crc_reg.abyte.lsb = size;

        'return crc_reg.inteiro;
        getCRC16 = crc_reg

    End Function

    Public Function calcCRC16(ByRef message As Byte(), ByRef size As Integer)
        '//Processa uma mensagem recebida e retorna o seu crc16
        '//Entradas:
        '//*msg -> ponteiro para a mensagem a ser processada
        '//size -> tamanho da mensagem a ser processada
        '//Saida:
        '//Retorna o crc16 calculado na ordem reversa


        Dim cont As UInteger
        Dim crc_reg As UInteger

        '//1o. passo:
        '//carregar o registro do CRC com 0xFFFF;
        crc_reg = &HFFFF
        cont = 0


        While size > 0
            crc_reg = crc16_byte(message(cont), crc_reg)
            size -= 1
            cont += 1
        End While

        'size = crc_reg.abyte.msb;
        'crc_reg.abyte.msb = crc_reg.abyte.lsb;
        'crc_reg.abyte.lsb = size;

        'return crc_reg.inteiro;
        'getCRC16 = crc_reg
        Return crc_reg

    End Function

    Public Function crc16_byte(ByVal Input As Byte, ByVal crc_atual As UInteger)

        '//Funcao uint16 crc16_byte( uchar input, uint16 crc_atual )
        '//Calcula o crc16 de um byte com relação a um crc16 previamente calculado
        '//Entradas:
        '//input     -> abyte a ser calculado o crc16
        '//crc_atual -> crc16 ja calculado/acumulado anteriormente. Este valor dever ser
        '//0xFFFF para o 1o. byte a ser calculado em uma mensagem(ver a funcao crc16(...))
        '//Saida:
        '//retorna o crc16 atualmente calculado, sem inverter seu resultado.

        '//1o. passo:  XOR com o 1o. byte da mensagem e o byte LSB do registro CRC

        crc_atual = crc_atual Xor Input

        '//variavel de entrada 'input' foi aqui reutilizada...	

        For Input = 0 To 7 Step 1

            If (crc_atual And &H1) > 0 Then
                crc_atual = (crc_atual >> 1)
                crc_atual = crc_atual Xor &HA001
            Else
                crc_atual = crc_atual >> 1
            End If

        Next

        Return crc_atual


    End Function




    Public Function Get_FrameRx()
        Dim CRC_R As UShort
        Dim i As Integer = 0

        Dim flag_return As Boolean = False

        If spModBus.BytesToRead < 2 Then
            cont_erro_crc += 1
            flag_return = False
        Else
            While (spModBus.BytesToRead <> 0)
                frame_rx(i) = Byte.Parse(spModBus.ReadByte())
                i += 1
            End While

            CRC_R = calcCRC16(frame_rx, i - 2) 'crc com bytes invertidos

            If (frame_rx(i - 2) = Byte.Parse(CRC_R And &HFF)) And (frame_rx(i - 1) = Byte.Parse(CRC_R >> 8)) Then
                flag_return = True
            Else
                cont_erro_crc += 1
                flag_return = False

            End If

            If (frame_rx(0) = cb_Endereco.SelectedIndex) Then
                flag_return = True
            Else
                cont_erro_endereco += 1
                flag_return = False

            End If
        End If

        Return flag_return

    End Function

    Public Function MontaFrameException(ByVal address As Byte, ByVal type As Byte, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort

        message(0) = Byte.Parse(address)
        message(1) = frame_rx(1) Or &H80
        message(2) = Byte.Parse(type)

        CRC = calcCRC16(message, 3) 'crc com bytes invertidos

        message(3) = Byte.Parse(CRC And &HFF) 'CRC(1)
        message(4) = Byte.Parse(CRC >> 8) 'CRC(0)

        ' CRC16 01 03 00 01 00 0A = 94 0D

        Return 5       'retorna tamanho do frame
    End Function

    Public Function MontaFrameCode3(ByVal address As Byte, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort
        Dim num_reg As UShort

        num_reg = (frame_rx(4) * 256) + frame_rx(5)
        message(0) = Byte.Parse(address)
        message(1) = 3
        message(2) = num_reg * 2

        For cont = 0 To num_reg - 1 Step 1
            message(cont + 3) = Byte.Parse((holding_register(cont) >> 8 And &HFF))
            message(cont + 4) = Byte.Parse((holding_register(cont)) And &HFF)
        Next

        CRC = calcCRC16(message, (num_reg * 2) + 3) 'crc com bytes invertidos

        message((num_reg * 2) + 3) = Byte.Parse(CRC And &HFF) 'CRC(1)
        message((num_reg * 2) + 4) = Byte.Parse(CRC >> 8) 'CRC(0)


        ' CRC16 01 03 00 01 00 0A = 94 0D

        Return (num_reg * 2) + 5        'retorna tamanho do frame
    End Function

    Public Function MontaFrameCode4(ByVal address As Byte, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort
        Dim num_reg As UShort

        num_reg = (frame_rx(4) * 256) + frame_rx(5)
        message(0) = Byte.Parse(address)
        message(1) = 4
        message(2) = num_reg * 2

        For cont = 0 To num_reg Step 1
            message(cont + 3) = Byte.Parse((input_register(cont) >> 8 And &HFF))
            message(cont + 4) = Byte.Parse((input_register(cont)) And &HFF)
        Next

        CRC = calcCRC16(message, (num_reg * 2) + 3) 'crc com bytes invertidos

        message((num_reg * 2) + 3) = Byte.Parse(CRC And &HFF) 'CRC(1)
        message((num_reg * 2) + 4) = Byte.Parse(CRC >> 8) 'CRC(0)


        ' CRC16 01 03 00 01 00 0A = 94 0D

        Return (num_reg * 2) + 5        'retorna tamanho do frame

    End Function

    Public Function MontaFrameCode6(ByVal address As Byte, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort

        message(0) = Byte.Parse(address)
        message(1) = frame_rx(1)
        message(2) = frame_rx(2)
        message(3) = frame_rx(3)
        message(4) = frame_rx(4)
        message(5) = frame_rx(5)

        CRC = calcCRC16(message, 6) 'crc com bytes invertidos

        message(6) = Byte.Parse(CRC And &HFF) 'CRC(1)
        message(7) = Byte.Parse(CRC >> 8) 'CRC(0)


        ' CRC16 01 03 00 01 00 0A = 94 0D

        Return 8       'retorna tamanho do frame

    End Function

    Public Function MontaFrameCode16(ByVal address As Byte, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort

        message(0) = Byte.Parse(address)
        message(1) = frame_rx(1)
        message(2) = frame_rx(2)
        message(3) = frame_rx(3)
        message(4) = frame_rx(4)
        message(5) = frame_rx(5)

        CRC = calcCRC16(message, 6) 'crc com bytes invertidos

        message(6) = Byte.Parse(CRC And &HFF) 'CRC(1)
        message(7) = Byte.Parse(CRC >> 8) 'CRC(0)


        ' CRC16 01 03 00 01 00 0A = 94 0D

        Return 8       'retorna tamanho do frame
    End Function



    Public Function ModBus_tx(ByRef message As Byte(), ByRef size As Integer)

        Dim flag As Boolean

        'Ensure port is open:
        If (spModBus.IsOpen) Then

            'Clear in/out buffers:
            spModBus.DiscardOutBuffer()
            spModBus.DiscardInBuffer()

            'Send modbus message to Serial Port:
            Try
                spModBus.Write(message, 0, size)

            Catch err As Exception
                modbusStatus = "Error: " + err.Message
                flag = False
            End Try
        Else

            modbusStatus = "Not open"
            flag = False
        End If

        If flag = True Then
            modbusStatus = ""
        End If

        Return flag

    End Function

    Public Sub WriteHoldingRegister(ByRef message As Byte())

        holding_register((message(2) * 256) + message(3)) = (message(4) * 256) + message(5)

    End Sub

    Public Sub WriteMultHoldingRegister(ByRef message As Byte())

        Dim ini_reg As Integer
        Dim num_reg As Integer
        Dim pos As Integer

        ini_reg = (message(2) * 256) + message(3)
        num_reg = (message(4) * 256) + message(5)
        pos = 0

        For cont = 0 To num_reg - 1 Step 1
            holding_register(cont + ini_reg) = (message(pos + 7) * 256) + message(pos + 8)
            pos += 2
        Next

    End Sub


    Private Sub BT_Modulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Modulos.Click
        Registros.WindowState = FormWindowState.Normal
        Registros.Show()
        Registros.Select()
        Registros.Focus()
    End Sub



    Private Sub Timer_frame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_frame.Tick

        Dim flag_status As Boolean
        Dim tamanho As Integer

        If flag_frame Then
            flag_frame = False
            cont_transacoes += 1

            If Get_FrameRx() Then
                cont_teste += 1


                Select Case frame_rx(1)
                    Case 3
                        tamanho = MontaFrameCode3(cb_Endereco.SelectedIndex, frame_tx)
                        ModBus_tx(frame_tx, tamanho)
                    Case 4
                        tamanho = MontaFrameCode4(cb_Endereco.SelectedIndex, frame_tx)
                        ModBus_tx(frame_tx, tamanho)
                    Case 6
                        tamanho = MontaFrameCode6(cb_Endereco.SelectedIndex, frame_tx)
                        WriteHoldingRegister(frame_rx)
                        ModBus_tx(frame_tx, tamanho)
                    Case 16

                        tamanho = MontaFrameCode16(cb_Endereco.SelectedIndex, frame_tx)
                        WriteMultHoldingRegister(frame_rx)
                        ModBus_tx(frame_tx, tamanho)
                    Case Else
                        tamanho = MontaFrameException(cb_Endereco.SelectedIndex, 1, frame_tx)
                        ModBus_tx(frame_tx, tamanho)
                End Select


            End If


        Else
            If spModBus.IsOpen Then

                If spModBus.BytesToRead > 0 Then

                    flag_frame = True
                End If

            End If
        End If




        label_cont_teste.Text = cont_teste



        flag_status = False

        cont_erro_geral = cont_erro_endereco + cont_erro_crc

        TB_serial_erro_total.Text = cont_erro_geral
        TB_serial_erro_endereco.Text = cont_erro_endereco
        TB_serial_erro_crc.Text = cont_erro_crc
        TB_serial_transacoes.Text = cont_transacoes

        cont_com += 1
        If cont_erro > 4 Then
            flag_link = False
            cont_erro = 0
            cont_com = 0
        ElseIf cont_com > 5 Then
            cont_com = 0
            flag_link = True
            cont_erro = 0
        End If



        If flag_link = True Then

            If estado_link <> 2 Then
                estado_link = 2

                Registros.Com_Comunicacao()


            End If

        Else


            If estado_link <> 1 Then
                estado_link = 1

                Registros.Sem_Comunicacao()

            End If

        End If



    End Sub

    Public Sub anima_com()

        Static Dim estado_link_memo As Byte

        If estado_link <> estado_link_memo Then

            estado_link_memo = estado_link

            Select Case estado_link
                Case 0
                    PB_com.Image = My.Resources.com_n
                Case 1
                    PB_com.Image = My.Resources.com_t
                Case 2
                    PB_com.Image = My.Resources.com_tr
            End Select

        End If

    End Sub

    Public Sub bt_Conect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Conect.Click
        If conec_flag = False Then
            conec_flag = True
            spModBus.BaudRate = "115200"
            spModBus.PortName = ComboBox_AvailableSerialPorts.SelectedItem
            bt_Conect.BackColor = Color.YellowGreen
            'Timer1.Enabled = True

            If spModBus.IsOpen = False Then
                spModBus.Open()

            End If
        Else

            flag_desconect_request = True


        End If

        estado_link = 0

    End Sub


End Class

