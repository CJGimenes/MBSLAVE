Module Publicos


    Enum cmdEscrita
        Parado
        botaoEnvia
        escritaSimples
    End Enum


    Public frame_rx As Byte() = New Byte(256) {}
    Public frame_tx As Byte() = New Byte(256) {}

    Public input_register As UShort() = New UShort(10000) {}
    Public holding_register As UShort() = New UShort(10000) {}
    Public input_register_status As Byte() = New Byte(10000) {}

    Public modbusStatus As String


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

        If Form_mbslave.spModBus.BytesToRead < 2 Then
            Form_mbslave.cont_erro_crc += 1
            flag_return = False
        Else
            While (Form_mbslave.spModBus.BytesToRead > 0 And i < 256)
                frame_rx(i) = Byte.Parse(Form_mbslave.spModBus.ReadByte())
                i += 1
            End While

            CRC_R = calcCRC16(frame_rx, i - 2) 'crc com bytes invertidos

            If (frame_rx(i - 2) = Byte.Parse(CRC_R And &HFF)) And (frame_rx(i - 1) = Byte.Parse(CRC_R >> 8)) Then
                flag_return = True
            Else
                Form_mbslave.cont_erro_crc += 1
                flag_return = False

            End If

            If (frame_rx(0) = Form_mbslave.cb_Endereco.SelectedIndex) Then
                flag_return = True
            Else
                Form_mbslave.cont_erro_endereco += 1
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

    Public Function LimitesCode3(ByRef message As Byte())

        Dim ini_reg As Integer
        Dim num_reg As Integer

        ini_reg = (message(2) * 256) + message(3)
        num_reg = (message(4) * 256) + message(5)

        If (ini_reg >= Form_mbslave.reg_escrita_inicio.Value) Then
            If ((ini_reg + num_reg) <= (Form_mbslave.reg_escrita_inicio.Value + Form_mbslave.reg_escrita_tamanho.Value)) Then

                Return True
            End If
        End If

        Return False
    End Function

    Public Function LimitesCode4(ByRef message As Byte())

        Dim ini_reg As Integer
        Dim num_reg As Integer

        ini_reg = (message(2) * 256) + message(3)
        num_reg = (message(4) * 256) + message(5)

        If (ini_reg >= Form_mbslave.reg_leitura_inicio.Value) Then
            If ((ini_reg + num_reg) <= (Form_mbslave.reg_leitura_inicio.Value + Form_mbslave.reg_leitura_tamanho.Value)) Then

                Return True
            End If
        End If

        Return False
    End Function

    Public Function LimitesCode6(ByRef message As Byte())

        Dim reg As Integer

        reg = (message(2) * 256) + message(3)

        If (reg >= Form_mbslave.reg_escrita_inicio.Value) Then
            If reg <= (Form_mbslave.reg_escrita_inicio.Value + Form_mbslave.reg_escrita_tamanho.Value) Then

                Return True
            End If
        End If

        Return False
    End Function

    Public Function LimitesCode16(ByRef message As Byte())

        Dim ini_reg As Integer
        Dim num_reg As Integer

        ini_reg = (message(2) * 256) + message(3)
        num_reg = (message(4) * 256) + message(5)

        If (ini_reg >= Form_mbslave.reg_escrita_inicio.Value) Then
            If ((ini_reg + num_reg) <= (Form_mbslave.reg_escrita_inicio.Value + Form_mbslave.reg_escrita_tamanho.Value)) Then

                Return True
            End If
        End If

        Return False
    End Function

    Public Function MontaFrameCode3(ByVal address As Byte, ByRef message As Byte())

        'Array to receive CRC bytes:
        Dim CRC As UShort
        Dim ini_reg As Integer
        Dim deslocamento As Integer
        Dim num_reg As Integer
        Dim pos As Integer

        ini_reg = (frame_rx(2) * 256) + frame_rx(3)
        deslocamento = ini_reg - Form_mbslave.reg_escrita_inicio.Value
        num_reg = (frame_rx(4) * 256) + frame_rx(5)
        message(0) = Byte.Parse(address)
        message(1) = 3
        message(2) = num_reg * 2
        pos = 0
        For cont = 0 To num_reg - 1 Step 1
            message(pos + 3) = Byte.Parse((holding_register(cont + deslocamento) >> 8) And &HFF)
            message(pos + 4) = Byte.Parse((holding_register(cont + deslocamento)) And &HFF)
            pos += 2
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
        Dim ini_reg As Integer
        Dim deslocamento As Integer
        Dim num_reg As Integer
        Dim pos As Integer

        ini_reg = (frame_rx(2) * 256) + frame_rx(3)
        deslocamento = ini_reg - Form_mbslave.reg_leitura_inicio.Value
        num_reg = (frame_rx(4) * 256) + frame_rx(5)
        message(0) = Byte.Parse(address)
        message(1) = 4
        message(2) = num_reg * 2
        pos = 0
        For cont = 0 To num_reg - 1 Step 1
            message(pos + 3) = Byte.Parse((input_register(cont + deslocamento) >> 8) And &HFF)
            message(pos + 4) = Byte.Parse((input_register(cont + deslocamento)) And &HFF)
            pos += 2
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
        If (Form_mbslave.spModBus.IsOpen) Then

            'Clear in/out buffers:
            Form_mbslave.spModBus.DiscardOutBuffer()
            Form_mbslave.spModBus.DiscardInBuffer()

            'Send modbus message to Serial Port:
            Try
                Form_mbslave.spModBus.Write(message, 0, size)

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

        Dim reg As Integer
        Dim deslocamento As Integer

        reg = (message(2) * 256) + message(3)
        deslocamento = reg - Form_mbslave.reg_escrita_inicio.Value

        holding_register(deslocamento) = (message(4) * 256) + message(5)

    End Sub

    Public Sub WriteMultHoldingRegister(ByRef message As Byte())

        Dim ini_reg As Integer
        Dim num_reg As Integer
        Dim deslocamento As Integer
        Dim pos As Integer

        ini_reg = (message(2) * 256) + message(3)
        deslocamento = ini_reg - Form_mbslave.reg_escrita_inicio.Value
        num_reg = (message(4) * 256) + message(5)
        pos = 0

        For cont = 0 To num_reg - 1 Step 1
            holding_register(cont + deslocamento) = (message(pos + 7) * 256) + message(pos + 8)
            pos += 2
        Next

    End Sub
End Module
