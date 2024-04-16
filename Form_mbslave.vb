Imports System.Threading
Imports System.Deployment.Application
Imports System.Security
Imports System.IO
Imports System.Text

Public Class Form_mbslave

    Public cont_erro_geral As Long = 0
    Public cont_erro_time_out As Long = 0
    Public cont_erro_endereco As Long = 0
    Public cont_erro_crc As Long = 0
    Public cont_transacoes As Long = 0
    Public cont_exception_1 As Long = 0
    Public cont_exception_2 As Long = 0
    Public time_out_read As Integer = 100

    Public modbus_transacao As Byte
    Public flag_frame As Boolean = False
    Public conec_flag As Boolean = False

    Public tab_leitura_inicio_memo As Long = 0
    Public reg_leitura_inicio_memo As Long = 0
    Public reg_leitura_tamanho_memo As Long = 0
    Public reg_leitura_alt As Boolean = False
    Public reg_escrita_inicio_memo As Long = 0
    Public reg_escrita_tamanho_memo As Long = 0
    Public reg_escrita_alt As Boolean = False




    'Public Sub Main()
    ' While 1

    'If spModBus.IsOpen Then
    'If Timer_frame.Enabled = False Then

    'If spModBus.BytesToRead > 0 Then

    'Timer_frame.Enabled = True
    'End If
    'End If
    'End If


    'End While
    'End Sub




    Private Sub Porta_Serial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializa()
        Timer_frame.Enabled = True

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

        reg_leitura_inicio.Value = 0
        reg_leitura_tamanho.Value = 100
        tab_leitura_inicio_memo = tab_leitura_inicio.Value
        reg_leitura_inicio_memo = reg_leitura_inicio.Value
        reg_leitura_tamanho_memo = reg_leitura_tamanho.Value
        reg_leitura_alt = False
        reg_escrita_inicio.Value = 0
        reg_escrita_tamanho.Value = 100
        reg_escrita_inicio_memo = reg_escrita_inicio.Value
        reg_escrita_tamanho_memo = reg_escrita_tamanho.Value
        reg_escrita_alt = False
        reg_select = 0
        ajustaEnderecoTabelaLeitura()
        ajustaEnderecoTabelaEscrita()


    End Sub

    Public Sub bt_at_port_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_at_port.Click
        AtualizaPorta()
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


    Private Sub Timer_frame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_frame.Tick

        Dim flag_status As Boolean
        Dim tamanho As Integer

        If flag_frame Then
            flag_frame = False
            cont_transacoes += 1

            If Get_FrameRx() Then

                Select Case frame_rx(1)
                    Case 3
                        If LimitesCode3(frame_rx) Then
                            tamanho = MontaFrameCode3(cb_Endereco.SelectedIndex, frame_tx)
                        Else
                            tamanho = MontaFrameException(cb_Endereco.SelectedIndex, 2, frame_tx)
                            cont_exception_2 += 1
                        End If
                        ModBus_tx(frame_tx, tamanho)
                    Case 4
                        If LimitesCode4(frame_rx) Then
                            tamanho = MontaFrameCode4(cb_Endereco.SelectedIndex, frame_tx)
                        Else
                            tamanho = MontaFrameException(cb_Endereco.SelectedIndex, 2, frame_tx)
                            cont_exception_2 += 1
                        End If
                        ModBus_tx(frame_tx, tamanho)
                    Case 6
                        If LimitesCode6(frame_rx) Then
                            tamanho = MontaFrameCode6(cb_Endereco.SelectedIndex, frame_tx)
                            WriteHoldingRegister(frame_rx)
                        Else
                            tamanho = MontaFrameException(cb_Endereco.SelectedIndex, 2, frame_tx)
                            cont_exception_2 += 1
                        End If
                        ModBus_tx(frame_tx, tamanho)
                    Case 16
                        If LimitesCode6(frame_rx) Then
                            tamanho = MontaFrameCode16(cb_Endereco.SelectedIndex, frame_tx)
                            WriteMultHoldingRegister(frame_rx)
                        Else
                            tamanho = MontaFrameException(cb_Endereco.SelectedIndex, 2, frame_tx)
                            cont_exception_2 += 1
                        End If
                        ModBus_tx(frame_tx, tamanho)
                    Case Else
                        tamanho = MontaFrameException(cb_Endereco.SelectedIndex, 1, frame_tx)
                        cont_exception_1 += 1
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


        flag_status = False

        cont_erro_geral = cont_erro_endereco + cont_erro_crc

        TB_serial_erro_total.Text = cont_erro_geral
        TB_serial_erro_endereco.Text = cont_erro_endereco
        TB_serial_erro_crc.Text = cont_erro_crc
        TB_serial_exception_1.Text = cont_exception_1
        TB_serial_exception_2.Text = cont_exception_2
        TB_serial_transacoes.Text = cont_transacoes



    End Sub

    Public Sub anima_com()



    End Sub

    Public Sub bt_Conect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Conect.Click
        If conec_flag = False Then

            If spModBus.IsOpen = False Then
                conec_flag = True
                spModBus.BaudRate = "115200"
                spModBus.PortName = ComboBox_AvailableSerialPorts.SelectedItem
                spModBus.Open()

                bt_Conect.BackColor = Color.YellowGreen

            End If
        Else
            conec_flag = False
            bt_Conect.BackColor = Color.Tomato
            If spModBus.IsOpen = True Then
                spModBus.Close()

            End If


        End If



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        regLeituraSel()
        apresentaValorTabelaLeitura()
        apresentaSelecaoTabelaLeitura()
        apresentaValorTabelaEscrita()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick


        If reg_leitura_alt Then
            reg_leitura_alt = False

            tab_leitura_inicio.Minimum = reg_leitura_inicio.Value
            tab_leitura_inicio.Value = reg_leitura_inicio.Value
            If reg_leitura_tamanho.Value >= 100 Then
                tab_leitura_inicio.Maximum = reg_leitura_inicio.Value + reg_leitura_tamanho.Value
            Else
                tab_leitura_inicio.Maximum = reg_leitura_inicio.Value
            End If

            reg_leitura_inicio_memo = reg_leitura_inicio.Value
            reg_leitura_tamanho_memo = reg_leitura_tamanho.Value
            BT_leitura_entra.BackColor = Color.LightGray

        ElseIf reg_leitura_inicio_memo <> reg_leitura_inicio.Value Or reg_leitura_tamanho_memo <> reg_leitura_tamanho.Value Then

            BT_leitura_entra.BackColor = Color.Red

        End If

        If reg_escrita_alt Then
            reg_escrita_alt = False

            tab_escrita_inicio.Minimum = reg_escrita_inicio.Value
            tab_escrita_inicio.Value = reg_escrita_inicio.Value
            If reg_escrita_tamanho.Value >= 100 Then
                tab_escrita_inicio.Maximum = reg_escrita_inicio.Value + reg_escrita_tamanho.Value
            Else
                tab_escrita_inicio.Maximum = reg_escrita_inicio.Value
            End If

            reg_escrita_inicio_memo = reg_escrita_inicio.Value
            reg_escrita_tamanho_memo = reg_escrita_tamanho.Value
            BT_escrita_entra.BackColor = Color.LightGray

        ElseIf reg_escrita_inicio_memo <> reg_escrita_inicio.Value Or reg_escrita_tamanho_memo <> reg_escrita_tamanho.Value Then

            BT_escrita_entra.BackColor = Color.Red

        End If

        deslocamento_leitura = tab_leitura_inicio.Value - reg_leitura_inicio_memo
        deslocamento_escrita = tab_escrita_inicio.Value - reg_escrita_inicio_memo

        regLeituraIncDec()

    End Sub

    Private Sub tab_valor_leitura_1_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_1.Click
        reg_select = 1
    End Sub
    Private Sub tab_valor_leitura_2_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_2.Click
        reg_select = 2
    End Sub
    Private Sub tab_valor_leitura_3_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_3.Click
        reg_select = 3
    End Sub
    Private Sub tab_valor_leitura_4_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_4.Click
        reg_select = 4
    End Sub
    Private Sub tab_valor_leitura_5_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_5.Click
        reg_select = 5
    End Sub
    Private Sub tab_valor_leitura_6_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_6.Click
        reg_select = 6
    End Sub
    Private Sub tab_valor_leitura_7_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_7.Click
        reg_select = 7
    End Sub
    Private Sub tab_valor_leitura_8_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_8.Click
        reg_select = 8
    End Sub
    Private Sub tab_valor_leitura_9_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_9.Click
        reg_select = 9
    End Sub
    Private Sub tab_valor_leitura_10_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_10.Click
        reg_select = 10
    End Sub
    Private Sub tab_valor_leitura_11_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_11.Click
        reg_select = 11
    End Sub
    Private Sub tab_valor_leitura_12_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_12.Click
        reg_select = 12
    End Sub
    Private Sub tab_valor_leitura_13_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_13.Click
        reg_select = 13
    End Sub
    Private Sub tab_valor_leitura_14_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_14.Click
        reg_select = 14
    End Sub
    Private Sub tab_valor_leitura_15_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_15.Click
        reg_select = 15
    End Sub
    Private Sub tab_valor_leitura_16_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_16.Click
        reg_select = 16
    End Sub
    Private Sub tab_valor_leitura_17_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_17.Click
        reg_select = 17
    End Sub
    Private Sub tab_valor_leitura_18_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_18.Click
        reg_select = 18
    End Sub
    Private Sub tab_valor_leitura_19_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_19.Click
        reg_select = 19
    End Sub
    Private Sub tab_valor_leitura_20_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_20.Click
        reg_select = 20
    End Sub
    Private Sub tab_valor_leitura_21_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_21.Click
        reg_select = 21
    End Sub
    Private Sub tab_valor_leitura_22_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_22.Click
        reg_select = 22
    End Sub
    Private Sub tab_valor_leitura_23_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_23.Click
        reg_select = 23
    End Sub
    Private Sub tab_valor_leitura_24_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_24.Click
        reg_select = 24
    End Sub
    Private Sub tab_valor_leitura_25_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_25.Click
        reg_select = 25
    End Sub
    Private Sub tab_valor_leitura_26_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_26.Click
        reg_select = 26
    End Sub
    Private Sub tab_valor_leitura_27_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_27.Click
        reg_select = 27
    End Sub
    Private Sub tab_valor_leitura_28_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_28.Click
        reg_select = 28
    End Sub
    Private Sub tab_valor_leitura_29_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_29.Click
        reg_select = 29
    End Sub
    Private Sub tab_valor_leitura_30_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_30.Click
        reg_select = 30
    End Sub
    Private Sub tab_valor_leitura_31_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_31.Click
        reg_select = 31
    End Sub
    Private Sub tab_valor_leitura_32_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_32.Click
        reg_select = 32
    End Sub
    Private Sub tab_valor_leitura_33_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_33.Click
        reg_select = 33
    End Sub
    Private Sub tab_valor_leitura_34_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_34.Click
        reg_select = 34
    End Sub
    Private Sub tab_valor_leitura_35_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_35.Click
        reg_select = 35
    End Sub
    Private Sub tab_valor_leitura_36_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_36.Click
        reg_select = 36
    End Sub
    Private Sub tab_valor_leitura_37_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_37.Click
        reg_select = 37
    End Sub
    Private Sub tab_valor_leitura_38_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_38.Click
        reg_select = 38
    End Sub
    Private Sub tab_valor_leitura_39_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_39.Click
        reg_select = 39
    End Sub
    Private Sub tab_valor_leitura_40_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_40.Click
        reg_select = 40
    End Sub
    Private Sub tab_valor_leitura_41_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_41.Click
        reg_select = 41
    End Sub
    Private Sub tab_valor_leitura_42_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_42.Click
        reg_select = 42
    End Sub
    Private Sub tab_valor_leitura_43_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_43.Click
        reg_select = 43
    End Sub
    Private Sub tab_valor_leitura_44_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_44.Click
        reg_select = 44
    End Sub
    Private Sub tab_valor_leitura_45_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_45.Click
        reg_select = 45
    End Sub
    Private Sub tab_valor_leitura_46_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_46.Click
        reg_select = 46
    End Sub
    Private Sub tab_valor_leitura_47_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_47.Click
        reg_select = 47
    End Sub
    Private Sub tab_valor_leitura_48_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_48.Click
        reg_select = 48
    End Sub
    Private Sub tab_valor_leitura_49_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_49.Click
        reg_select = 49
    End Sub
    Private Sub tab_valor_leitura_50_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_50.Click
        reg_select = 50
    End Sub
    Private Sub tab_valor_leitura_51_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_51.Click
        reg_select = 51
    End Sub
    Private Sub tab_valor_leitura_52_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_52.Click
        reg_select = 52
    End Sub
    Private Sub tab_valor_leitura_53_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_53.Click
        reg_select = 53
    End Sub
    Private Sub tab_valor_leitura_54_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_54.Click
        reg_select = 54
    End Sub
    Private Sub tab_valor_leitura_55_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_55.Click
        reg_select = 55
    End Sub
    Private Sub tab_valor_leitura_56_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_56.Click
        reg_select = 56
    End Sub
    Private Sub tab_valor_leitura_57_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_57.Click
        reg_select = 57
    End Sub
    Private Sub tab_valor_leitura_58_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_58.Click
        reg_select = 58
    End Sub
    Private Sub tab_valor_leitura_59_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_59.Click
        reg_select = 59
    End Sub
    Private Sub tab_valor_leitura_60_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_60.Click
        reg_select = 60
    End Sub
    Private Sub tab_valor_leitura_61_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_61.Click
        reg_select = 61
    End Sub
    Private Sub tab_valor_leitura_62_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_62.Click
        reg_select = 62
    End Sub
    Private Sub tab_valor_leitura_63_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_63.Click
        reg_select = 63
    End Sub
    Private Sub tab_valor_leitura_64_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_64.Click
        reg_select = 64
    End Sub
    Private Sub tab_valor_leitura_65_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_65.Click
        reg_select = 65
    End Sub
    Private Sub tab_valor_leitura_66_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_66.Click
        reg_select = 66
    End Sub
    Private Sub tab_valor_leitura_67_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_67.Click
        reg_select = 67
    End Sub
    Private Sub tab_valor_leitura_68_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_68.Click
        reg_select = 68
    End Sub
    Private Sub tab_valor_leitura_69_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_69.Click
        reg_select = 69
    End Sub
    Private Sub tab_valor_leitura_70_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_70.Click
        reg_select = 70
    End Sub
    Private Sub tab_valor_leitura_71_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_71.Click
        reg_select = 71
    End Sub
    Private Sub tab_valor_leitura_72_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_72.Click
        reg_select = 72
    End Sub
    Private Sub tab_valor_leitura_73_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_73.Click
        reg_select = 73
    End Sub
    Private Sub tab_valor_leitura_74_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_74.Click
        reg_select = 74
    End Sub
    Private Sub tab_valor_leitura_75_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_75.Click
        reg_select = 75
    End Sub
    Private Sub tab_valor_leitura_76_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_76.Click
        reg_select = 76
    End Sub
    Private Sub tab_valor_leitura_77_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_77.Click
        reg_select = 77
    End Sub
    Private Sub tab_valor_leitura_78_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_78.Click
        reg_select = 78
    End Sub
    Private Sub tab_valor_leitura_79_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_79.Click
        reg_select = 79
    End Sub
    Private Sub tab_valor_leitura_80_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_80.Click
        reg_select = 80
    End Sub
    Private Sub tab_valor_leitura_81_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_81.Click
        reg_select = 81
    End Sub
    Private Sub tab_valor_leitura_82_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_82.Click
        reg_select = 82
    End Sub
    Private Sub tab_valor_leitura_83_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_83.Click
        reg_select = 83
    End Sub
    Private Sub tab_valor_leitura_84_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_84.Click
        reg_select = 84
    End Sub
    Private Sub tab_valor_leitura_85_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_85.Click
        reg_select = 85
    End Sub
    Private Sub tab_valor_leitura_86_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_86.Click
        reg_select = 86
    End Sub
    Private Sub tab_valor_leitura_87_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_87.Click
        reg_select = 87
    End Sub
    Private Sub tab_valor_leitura_88_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_88.Click
        reg_select = 88
    End Sub
    Private Sub tab_valor_leitura_89_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_89.Click
        reg_select = 89
    End Sub
    Private Sub tab_valor_leitura_90_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_90.Click
        reg_select = 90
    End Sub
    Private Sub tab_valor_leitura_91_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_91.Click
        reg_select = 91
    End Sub
    Private Sub tab_valor_leitura_92_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_92.Click
        reg_select = 92
    End Sub
    Private Sub tab_valor_leitura_93_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_93.Click
        reg_select = 93
    End Sub
    Private Sub tab_valor_leitura_94_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_94.Click
        reg_select = 94
    End Sub
    Private Sub tab_valor_leitura_95_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_95.Click
        reg_select = 95
    End Sub
    Private Sub tab_valor_leitura_96_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_96.Click
        reg_select = 96
    End Sub
    Private Sub tab_valor_leitura_97_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_97.Click
        reg_select = 97
    End Sub
    Private Sub tab_valor_leitura_98_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_98.Click
        reg_select = 98
    End Sub
    Private Sub tab_valor_leitura_99_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_99.Click
        reg_select = 99
    End Sub
    Private Sub tab_valor_leitura_100_Click(sender As Object, e As EventArgs) Handles tab_valor_leitura_100.Click
        reg_select = 100
    End Sub

    Private Sub BT_fecha_Click(sender As Object, e As EventArgs) Handles BT_fecha.Click
        reg_select = 0
    End Sub

    Private Sub tab_leitura_inicio_ValueChanged(sender As Object, e As EventArgs) Handles tab_leitura_inicio.ValueChanged
        ajustaEnderecoTabelaLeitura()
        reg_select = 0
    End Sub

    Private Sub tab_escrita_inicio_ValueChanged(sender As Object, e As EventArgs) Handles tab_escrita_inicio.ValueChanged
        ajustaEnderecoTabelaEscrita()
    End Sub

    Private Sub BT_entra_sel_Click(sender As Object, e As EventArgs) Handles BT_entra_sel.Click
        'input_register((reg_select - 1) + deslocamento_leitura) = valor_sel.Value
    End Sub

    Private Sub valor_sel_ValueChanged(sender As Object, e As EventArgs) Handles valor_sel.ValueChanged
        input_register((reg_select - 1) + deslocamento_leitura) = valor_sel.Value
    End Sub

    Private Sub RadioButton_Incrementa_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Incrementa.CheckedChanged
        input_register_status((reg_select - 1) + deslocamento_leitura) = 1
    End Sub

    Private Sub RadioButton_Normal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Normal.CheckedChanged
        input_register_status((reg_select - 1) + deslocamento_leitura) = 0
    End Sub

    Private Sub RadioButton_decrementa_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_decrementa.CheckedChanged
        input_register_status((reg_select - 1) + deslocamento_leitura) = 2
    End Sub

    Private Sub BT_leitura_entra_Click(sender As Object, e As EventArgs) Handles BT_leitura_entra.Click
        reg_leitura_alt = True

    End Sub

    Private Sub BT_escrita_entra_Click(sender As Object, e As EventArgs) Handles BT_escrita_entra.Click
        reg_escrita_alt = True

    End Sub

    Private Sub Reset_cont_erro_serial_Click(sender As Object, e As EventArgs) Handles Reset_cont_erro_serial.Click
        cont_erro_geral = 0
        cont_erro_endereco = 0
        cont_erro_crc = 0
        cont_exception_1 = 0
        cont_exception_2 = 0
        cont_transacoes = 0

        TB_serial_erro_total.Text = cont_erro_geral
        TB_serial_erro_endereco.Text = cont_erro_endereco
        TB_serial_erro_crc.Text = cont_erro_crc
        TB_serial_exception_1.Text = cont_exception_1
        TB_serial_exception_2.Text = cont_exception_2
        TB_serial_transacoes.Text = cont_transacoes

    End Sub
End Class

