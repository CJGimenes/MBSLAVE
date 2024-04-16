Module Reg_leitura

    Public conec_flag As Boolean = False
    Public reg_select As Byte = 0
    Public reg_select_memo As Byte = 1
    Public tempo As Byte = 0
    Public deslocamento_leitura As Integer




    Public Sub regLeituraSel()
        If reg_select <> reg_select_memo Then
            reg_select_memo = reg_select


            If reg_select = 1 Then
                Form_mbslave.tab_valor_leitura_1.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_1.BackColor = Color.White
            End If

            If reg_select = 2 Then
                Form_mbslave.tab_valor_leitura_2.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_2.BackColor = Color.White
            End If

            If reg_select = 3 Then
                Form_mbslave.tab_valor_leitura_3.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_3.BackColor = Color.White
            End If

            If reg_select = 4 Then
                Form_mbslave.tab_valor_leitura_4.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_4.BackColor = Color.White
            End If

            If reg_select = 5 Then
                Form_mbslave.tab_valor_leitura_5.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_5.BackColor = Color.White
            End If

            If reg_select = 6 Then
                Form_mbslave.tab_valor_leitura_6.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_6.BackColor = Color.White
            End If

            If reg_select = 7 Then
                Form_mbslave.tab_valor_leitura_7.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_7.BackColor = Color.White
            End If

            If reg_select = 8 Then
                Form_mbslave.tab_valor_leitura_8.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_8.BackColor = Color.White
            End If

            If reg_select = 9 Then
                Form_mbslave.tab_valor_leitura_9.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_9.BackColor = Color.White
            End If

            If reg_select = 10 Then
                Form_mbslave.tab_valor_leitura_10.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_10.BackColor = Color.White
            End If

            If reg_select = 11 Then
                Form_mbslave.tab_valor_leitura_11.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_11.BackColor = Color.White
            End If

            If reg_select = 12 Then
                Form_mbslave.tab_valor_leitura_12.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_12.BackColor = Color.White
            End If

            If reg_select = 13 Then
                Form_mbslave.tab_valor_leitura_13.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_13.BackColor = Color.White
            End If

            If reg_select = 14 Then
                Form_mbslave.tab_valor_leitura_14.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_14.BackColor = Color.White
            End If

            If reg_select = 15 Then
                Form_mbslave.tab_valor_leitura_15.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_15.BackColor = Color.White
            End If

            If reg_select = 16 Then
                Form_mbslave.tab_valor_leitura_16.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_16.BackColor = Color.White
            End If

            If reg_select = 17 Then
                Form_mbslave.tab_valor_leitura_17.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_17.BackColor = Color.White
            End If

            If reg_select = 18 Then
                Form_mbslave.tab_valor_leitura_18.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_18.BackColor = Color.White
            End If

            If reg_select = 19 Then
                Form_mbslave.tab_valor_leitura_19.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_19.BackColor = Color.White
            End If

            If reg_select = 20 Then
                Form_mbslave.tab_valor_leitura_20.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_20.BackColor = Color.White
            End If

            If reg_select = 21 Then
                Form_mbslave.tab_valor_leitura_21.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_21.BackColor = Color.White
            End If

            If reg_select = 22 Then
                Form_mbslave.tab_valor_leitura_22.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_22.BackColor = Color.White
            End If

            If reg_select = 23 Then
                Form_mbslave.tab_valor_leitura_23.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_23.BackColor = Color.White
            End If

            If reg_select = 24 Then
                Form_mbslave.tab_valor_leitura_24.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_24.BackColor = Color.White
            End If

            If reg_select = 25 Then
                Form_mbslave.tab_valor_leitura_25.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_25.BackColor = Color.White
            End If

            If reg_select = 26 Then
                Form_mbslave.tab_valor_leitura_26.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_26.BackColor = Color.White
            End If

            If reg_select = 27 Then
                Form_mbslave.tab_valor_leitura_27.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_27.BackColor = Color.White
            End If

            If reg_select = 28 Then
                Form_mbslave.tab_valor_leitura_28.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_28.BackColor = Color.White
            End If

            If reg_select = 29 Then
                Form_mbslave.tab_valor_leitura_29.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_29.BackColor = Color.White
            End If

            If reg_select = 30 Then
                Form_mbslave.tab_valor_leitura_30.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_30.BackColor = Color.White
            End If

            If reg_select = 31 Then
                Form_mbslave.tab_valor_leitura_31.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_31.BackColor = Color.White
            End If

            If reg_select = 32 Then
                Form_mbslave.tab_valor_leitura_32.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_32.BackColor = Color.White
            End If

            If reg_select = 33 Then
                Form_mbslave.tab_valor_leitura_33.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_33.BackColor = Color.White
            End If

            If reg_select = 34 Then
                Form_mbslave.tab_valor_leitura_34.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_34.BackColor = Color.White
            End If

            If reg_select = 35 Then
                Form_mbslave.tab_valor_leitura_35.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_35.BackColor = Color.White
            End If

            If reg_select = 36 Then
                Form_mbslave.tab_valor_leitura_36.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_36.BackColor = Color.White
            End If

            If reg_select = 37 Then
                Form_mbslave.tab_valor_leitura_37.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_37.BackColor = Color.White
            End If

            If reg_select = 38 Then
                Form_mbslave.tab_valor_leitura_38.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_38.BackColor = Color.White
            End If

            If reg_select = 39 Then
                Form_mbslave.tab_valor_leitura_39.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_39.BackColor = Color.White
            End If

            If reg_select = 40 Then
                Form_mbslave.tab_valor_leitura_40.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_40.BackColor = Color.White
            End If

            If reg_select = 41 Then
                Form_mbslave.tab_valor_leitura_41.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_41.BackColor = Color.White
            End If

            If reg_select = 42 Then
                Form_mbslave.tab_valor_leitura_42.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_42.BackColor = Color.White
            End If

            If reg_select = 43 Then
                Form_mbslave.tab_valor_leitura_43.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_43.BackColor = Color.White
            End If

            If reg_select = 44 Then
                Form_mbslave.tab_valor_leitura_44.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_44.BackColor = Color.White
            End If

            If reg_select = 45 Then
                Form_mbslave.tab_valor_leitura_45.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_45.BackColor = Color.White
            End If

            If reg_select = 46 Then
                Form_mbslave.tab_valor_leitura_46.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_46.BackColor = Color.White
            End If

            If reg_select = 47 Then
                Form_mbslave.tab_valor_leitura_47.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_47.BackColor = Color.White
            End If

            If reg_select = 48 Then
                Form_mbslave.tab_valor_leitura_48.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_48.BackColor = Color.White
            End If

            If reg_select = 49 Then
                Form_mbslave.tab_valor_leitura_49.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_49.BackColor = Color.White
            End If

            If reg_select = 50 Then
                Form_mbslave.tab_valor_leitura_50.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_50.BackColor = Color.White
            End If

            If reg_select = 51 Then
                Form_mbslave.tab_valor_leitura_51.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_51.BackColor = Color.White
            End If

            If reg_select = 52 Then
                Form_mbslave.tab_valor_leitura_52.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_52.BackColor = Color.White
            End If

            If reg_select = 53 Then
                Form_mbslave.tab_valor_leitura_53.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_53.BackColor = Color.White
            End If

            If reg_select = 54 Then
                Form_mbslave.tab_valor_leitura_54.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_54.BackColor = Color.White
            End If

            If reg_select = 55 Then
                Form_mbslave.tab_valor_leitura_55.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_55.BackColor = Color.White
            End If

            If reg_select = 56 Then
                Form_mbslave.tab_valor_leitura_56.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_56.BackColor = Color.White
            End If

            If reg_select = 57 Then
                Form_mbslave.tab_valor_leitura_57.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_57.BackColor = Color.White
            End If

            If reg_select = 58 Then
                Form_mbslave.tab_valor_leitura_58.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_58.BackColor = Color.White
            End If

            If reg_select = 59 Then
                Form_mbslave.tab_valor_leitura_59.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_59.BackColor = Color.White
            End If

            If reg_select = 60 Then
                Form_mbslave.tab_valor_leitura_60.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_60.BackColor = Color.White
            End If

            If reg_select = 61 Then
                Form_mbslave.tab_valor_leitura_61.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_61.BackColor = Color.White
            End If

            If reg_select = 62 Then
                Form_mbslave.tab_valor_leitura_62.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_62.BackColor = Color.White
            End If

            If reg_select = 63 Then
                Form_mbslave.tab_valor_leitura_63.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_63.BackColor = Color.White
            End If

            If reg_select = 64 Then
                Form_mbslave.tab_valor_leitura_64.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_64.BackColor = Color.White
            End If

            If reg_select = 65 Then
                Form_mbslave.tab_valor_leitura_65.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_65.BackColor = Color.White
            End If

            If reg_select = 66 Then
                Form_mbslave.tab_valor_leitura_66.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_66.BackColor = Color.White
            End If

            If reg_select = 67 Then
                Form_mbslave.tab_valor_leitura_67.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_67.BackColor = Color.White
            End If

            If reg_select = 68 Then
                Form_mbslave.tab_valor_leitura_68.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_68.BackColor = Color.White
            End If

            If reg_select = 69 Then
                Form_mbslave.tab_valor_leitura_69.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_69.BackColor = Color.White
            End If

            If reg_select = 70 Then
                Form_mbslave.tab_valor_leitura_70.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_70.BackColor = Color.White
            End If

            If reg_select = 71 Then
                Form_mbslave.tab_valor_leitura_71.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_71.BackColor = Color.White
            End If

            If reg_select = 72 Then
                Form_mbslave.tab_valor_leitura_72.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_72.BackColor = Color.White
            End If

            If reg_select = 73 Then
                Form_mbslave.tab_valor_leitura_73.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_73.BackColor = Color.White
            End If

            If reg_select = 74 Then
                Form_mbslave.tab_valor_leitura_74.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_74.BackColor = Color.White
            End If

            If reg_select = 75 Then
                Form_mbslave.tab_valor_leitura_75.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_75.BackColor = Color.White
            End If

            If reg_select = 76 Then
                Form_mbslave.tab_valor_leitura_76.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_76.BackColor = Color.White
            End If

            If reg_select = 77 Then
                Form_mbslave.tab_valor_leitura_77.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_77.BackColor = Color.White
            End If

            If reg_select = 78 Then
                Form_mbslave.tab_valor_leitura_78.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_78.BackColor = Color.White
            End If

            If reg_select = 79 Then
                Form_mbslave.tab_valor_leitura_79.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_79.BackColor = Color.White
            End If

            If reg_select = 80 Then
                Form_mbslave.tab_valor_leitura_80.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_80.BackColor = Color.White
            End If

            If reg_select = 81 Then
                Form_mbslave.tab_valor_leitura_81.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_81.BackColor = Color.White
            End If

            If reg_select = 82 Then
                Form_mbslave.tab_valor_leitura_82.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_82.BackColor = Color.White
            End If

            If reg_select = 83 Then
                Form_mbslave.tab_valor_leitura_83.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_83.BackColor = Color.White
            End If

            If reg_select = 84 Then
                Form_mbslave.tab_valor_leitura_84.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_84.BackColor = Color.White
            End If

            If reg_select = 85 Then
                Form_mbslave.tab_valor_leitura_85.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_85.BackColor = Color.White
            End If

            If reg_select = 86 Then
                Form_mbslave.tab_valor_leitura_86.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_86.BackColor = Color.White
            End If

            If reg_select = 87 Then
                Form_mbslave.tab_valor_leitura_87.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_87.BackColor = Color.White
            End If

            If reg_select = 88 Then
                Form_mbslave.tab_valor_leitura_88.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_88.BackColor = Color.White
            End If

            If reg_select = 89 Then
                Form_mbslave.tab_valor_leitura_89.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_89.BackColor = Color.White
            End If

            If reg_select = 90 Then
                Form_mbslave.tab_valor_leitura_90.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_90.BackColor = Color.White
            End If

            If reg_select = 91 Then
                Form_mbslave.tab_valor_leitura_91.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_91.BackColor = Color.White
            End If

            If reg_select = 92 Then
                Form_mbslave.tab_valor_leitura_92.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_92.BackColor = Color.White
            End If

            If reg_select = 93 Then
                Form_mbslave.tab_valor_leitura_93.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_93.BackColor = Color.White
            End If

            If reg_select = 94 Then
                Form_mbslave.tab_valor_leitura_94.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_94.BackColor = Color.White
            End If

            If reg_select = 95 Then
                Form_mbslave.tab_valor_leitura_95.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_95.BackColor = Color.White
            End If

            If reg_select = 96 Then
                Form_mbslave.tab_valor_leitura_96.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_96.BackColor = Color.White
            End If

            If reg_select = 97 Then
                Form_mbslave.tab_valor_leitura_97.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_97.BackColor = Color.White
            End If

            If reg_select = 98 Then
                Form_mbslave.tab_valor_leitura_98.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_98.BackColor = Color.White
            End If

            If reg_select = 99 Then
                Form_mbslave.tab_valor_leitura_99.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_99.BackColor = Color.White
            End If

            If reg_select = 100 Then
                Form_mbslave.tab_valor_leitura_100.BackColor = Color.Yellow
            Else
                Form_mbslave.tab_valor_leitura_100.BackColor = Color.White
            End If

        End If



    End Sub


    Public Sub regLeituraIncDec()

        tempo += 1
        If tempo = 10 Then
            tempo = 0

            For cont = 0 To Form_mbslave.reg_leitura_tamanho.Value - 1 Step 1
                If input_register_status(cont) = 1 Then
                    If input_register(cont) < 65535 Then
                        input_register(cont) += 1
                    Else
                        input_register(cont) = 0
                    End If

                ElseIf input_register_status(cont) = 2 Then
                    If input_register(cont) > 0 Then
                        input_register(cont) -= 1
                    Else
                        input_register(cont) = 65535
                    End If

                End If
            Next
        End If



    End Sub


    Public Sub ajustaEnderecoTabelaLeitura()
        Form_mbslave.tab_endereco_leitura_1.Text = Form_mbslave.tab_leitura_inicio.Value + 0
        Form_mbslave.tab_endereco_leitura_2.Text = Form_mbslave.tab_leitura_inicio.Value + 1
        Form_mbslave.tab_endereco_leitura_3.Text = Form_mbslave.tab_leitura_inicio.Value + 2
        Form_mbslave.tab_endereco_leitura_4.Text = Form_mbslave.tab_leitura_inicio.Value + 3
        Form_mbslave.tab_endereco_leitura_5.Text = Form_mbslave.tab_leitura_inicio.Value + 4
        Form_mbslave.tab_endereco_leitura_6.Text = Form_mbslave.tab_leitura_inicio.Value + 5
        Form_mbslave.tab_endereco_leitura_7.Text = Form_mbslave.tab_leitura_inicio.Value + 6
        Form_mbslave.tab_endereco_leitura_8.Text = Form_mbslave.tab_leitura_inicio.Value + 7
        Form_mbslave.tab_endereco_leitura_9.Text = Form_mbslave.tab_leitura_inicio.Value + 8
        Form_mbslave.tab_endereco_leitura_10.Text = Form_mbslave.tab_leitura_inicio.Value + 9

        Form_mbslave.tab_endereco_leitura_11.Text = Form_mbslave.tab_leitura_inicio.Value + 10
        Form_mbslave.tab_endereco_leitura_12.Text = Form_mbslave.tab_leitura_inicio.Value + 11
        Form_mbslave.tab_endereco_leitura_13.Text = Form_mbslave.tab_leitura_inicio.Value + 12
        Form_mbslave.tab_endereco_leitura_14.Text = Form_mbslave.tab_leitura_inicio.Value + 13
        Form_mbslave.tab_endereco_leitura_15.Text = Form_mbslave.tab_leitura_inicio.Value + 14
        Form_mbslave.tab_endereco_leitura_16.Text = Form_mbslave.tab_leitura_inicio.Value + 15
        Form_mbslave.tab_endereco_leitura_17.Text = Form_mbslave.tab_leitura_inicio.Value + 16
        Form_mbslave.tab_endereco_leitura_18.Text = Form_mbslave.tab_leitura_inicio.Value + 17
        Form_mbslave.tab_endereco_leitura_19.Text = Form_mbslave.tab_leitura_inicio.Value + 18
        Form_mbslave.tab_endereco_leitura_20.Text = Form_mbslave.tab_leitura_inicio.Value + 19

        Form_mbslave.tab_endereco_leitura_21.Text = Form_mbslave.tab_leitura_inicio.Value + 20
        Form_mbslave.tab_endereco_leitura_22.Text = Form_mbslave.tab_leitura_inicio.Value + 21
        Form_mbslave.tab_endereco_leitura_23.Text = Form_mbslave.tab_leitura_inicio.Value + 22
        Form_mbslave.tab_endereco_leitura_24.Text = Form_mbslave.tab_leitura_inicio.Value + 23
        Form_mbslave.tab_endereco_leitura_25.Text = Form_mbslave.tab_leitura_inicio.Value + 24
        Form_mbslave.tab_endereco_leitura_26.Text = Form_mbslave.tab_leitura_inicio.Value + 25
        Form_mbslave.tab_endereco_leitura_27.Text = Form_mbslave.tab_leitura_inicio.Value + 26
        Form_mbslave.tab_endereco_leitura_28.Text = Form_mbslave.tab_leitura_inicio.Value + 27
        Form_mbslave.tab_endereco_leitura_29.Text = Form_mbslave.tab_leitura_inicio.Value + 28
        Form_mbslave.tab_endereco_leitura_30.Text = Form_mbslave.tab_leitura_inicio.Value + 29

        Form_mbslave.tab_endereco_leitura_31.Text = Form_mbslave.tab_leitura_inicio.Value + 30
        Form_mbslave.tab_endereco_leitura_32.Text = Form_mbslave.tab_leitura_inicio.Value + 31
        Form_mbslave.tab_endereco_leitura_33.Text = Form_mbslave.tab_leitura_inicio.Value + 32
        Form_mbslave.tab_endereco_leitura_34.Text = Form_mbslave.tab_leitura_inicio.Value + 33
        Form_mbslave.tab_endereco_leitura_35.Text = Form_mbslave.tab_leitura_inicio.Value + 34
        Form_mbslave.tab_endereco_leitura_36.Text = Form_mbslave.tab_leitura_inicio.Value + 35
        Form_mbslave.tab_endereco_leitura_37.Text = Form_mbslave.tab_leitura_inicio.Value + 36
        Form_mbslave.tab_endereco_leitura_38.Text = Form_mbslave.tab_leitura_inicio.Value + 37
        Form_mbslave.tab_endereco_leitura_39.Text = Form_mbslave.tab_leitura_inicio.Value + 38
        Form_mbslave.tab_endereco_leitura_40.Text = Form_mbslave.tab_leitura_inicio.Value + 39

        Form_mbslave.tab_endereco_leitura_41.Text = Form_mbslave.tab_leitura_inicio.Value + 40
        Form_mbslave.tab_endereco_leitura_42.Text = Form_mbslave.tab_leitura_inicio.Value + 41
        Form_mbslave.tab_endereco_leitura_43.Text = Form_mbslave.tab_leitura_inicio.Value + 42
        Form_mbslave.tab_endereco_leitura_44.Text = Form_mbslave.tab_leitura_inicio.Value + 43
        Form_mbslave.tab_endereco_leitura_45.Text = Form_mbslave.tab_leitura_inicio.Value + 44
        Form_mbslave.tab_endereco_leitura_46.Text = Form_mbslave.tab_leitura_inicio.Value + 45
        Form_mbslave.tab_endereco_leitura_47.Text = Form_mbslave.tab_leitura_inicio.Value + 46
        Form_mbslave.tab_endereco_leitura_48.Text = Form_mbslave.tab_leitura_inicio.Value + 47
        Form_mbslave.tab_endereco_leitura_49.Text = Form_mbslave.tab_leitura_inicio.Value + 48
        Form_mbslave.tab_endereco_leitura_50.Text = Form_mbslave.tab_leitura_inicio.Value + 49

        Form_mbslave.tab_endereco_leitura_51.Text = Form_mbslave.tab_leitura_inicio.Value + 50
        Form_mbslave.tab_endereco_leitura_52.Text = Form_mbslave.tab_leitura_inicio.Value + 51
        Form_mbslave.tab_endereco_leitura_53.Text = Form_mbslave.tab_leitura_inicio.Value + 52
        Form_mbslave.tab_endereco_leitura_54.Text = Form_mbslave.tab_leitura_inicio.Value + 53
        Form_mbslave.tab_endereco_leitura_55.Text = Form_mbslave.tab_leitura_inicio.Value + 54
        Form_mbslave.tab_endereco_leitura_56.Text = Form_mbslave.tab_leitura_inicio.Value + 55
        Form_mbslave.tab_endereco_leitura_57.Text = Form_mbslave.tab_leitura_inicio.Value + 56
        Form_mbslave.tab_endereco_leitura_58.Text = Form_mbslave.tab_leitura_inicio.Value + 57
        Form_mbslave.tab_endereco_leitura_59.Text = Form_mbslave.tab_leitura_inicio.Value + 58
        Form_mbslave.tab_endereco_leitura_60.Text = Form_mbslave.tab_leitura_inicio.Value + 59

        Form_mbslave.tab_endereco_leitura_61.Text = Form_mbslave.tab_leitura_inicio.Value + 60
        Form_mbslave.tab_endereco_leitura_62.Text = Form_mbslave.tab_leitura_inicio.Value + 61
        Form_mbslave.tab_endereco_leitura_63.Text = Form_mbslave.tab_leitura_inicio.Value + 62
        Form_mbslave.tab_endereco_leitura_64.Text = Form_mbslave.tab_leitura_inicio.Value + 63
        Form_mbslave.tab_endereco_leitura_65.Text = Form_mbslave.tab_leitura_inicio.Value + 64
        Form_mbslave.tab_endereco_leitura_66.Text = Form_mbslave.tab_leitura_inicio.Value + 65
        Form_mbslave.tab_endereco_leitura_67.Text = Form_mbslave.tab_leitura_inicio.Value + 66
        Form_mbslave.tab_endereco_leitura_68.Text = Form_mbslave.tab_leitura_inicio.Value + 67
        Form_mbslave.tab_endereco_leitura_69.Text = Form_mbslave.tab_leitura_inicio.Value + 68
        Form_mbslave.tab_endereco_leitura_70.Text = Form_mbslave.tab_leitura_inicio.Value + 69

        Form_mbslave.tab_endereco_leitura_71.Text = Form_mbslave.tab_leitura_inicio.Value + 70
        Form_mbslave.tab_endereco_leitura_72.Text = Form_mbslave.tab_leitura_inicio.Value + 71
        Form_mbslave.tab_endereco_leitura_73.Text = Form_mbslave.tab_leitura_inicio.Value + 72
        Form_mbslave.tab_endereco_leitura_74.Text = Form_mbslave.tab_leitura_inicio.Value + 73
        Form_mbslave.tab_endereco_leitura_75.Text = Form_mbslave.tab_leitura_inicio.Value + 74
        Form_mbslave.tab_endereco_leitura_76.Text = Form_mbslave.tab_leitura_inicio.Value + 75
        Form_mbslave.tab_endereco_leitura_77.Text = Form_mbslave.tab_leitura_inicio.Value + 76
        Form_mbslave.tab_endereco_leitura_78.Text = Form_mbslave.tab_leitura_inicio.Value + 77
        Form_mbslave.tab_endereco_leitura_79.Text = Form_mbslave.tab_leitura_inicio.Value + 78
        Form_mbslave.tab_endereco_leitura_80.Text = Form_mbslave.tab_leitura_inicio.Value + 79

        Form_mbslave.tab_endereco_leitura_81.Text = Form_mbslave.tab_leitura_inicio.Value + 80
        Form_mbslave.tab_endereco_leitura_82.Text = Form_mbslave.tab_leitura_inicio.Value + 81
        Form_mbslave.tab_endereco_leitura_83.Text = Form_mbslave.tab_leitura_inicio.Value + 82
        Form_mbslave.tab_endereco_leitura_84.Text = Form_mbslave.tab_leitura_inicio.Value + 83
        Form_mbslave.tab_endereco_leitura_85.Text = Form_mbslave.tab_leitura_inicio.Value + 84
        Form_mbslave.tab_endereco_leitura_86.Text = Form_mbslave.tab_leitura_inicio.Value + 85
        Form_mbslave.tab_endereco_leitura_87.Text = Form_mbslave.tab_leitura_inicio.Value + 86
        Form_mbslave.tab_endereco_leitura_88.Text = Form_mbslave.tab_leitura_inicio.Value + 87
        Form_mbslave.tab_endereco_leitura_89.Text = Form_mbslave.tab_leitura_inicio.Value + 88
        Form_mbslave.tab_endereco_leitura_90.Text = Form_mbslave.tab_leitura_inicio.Value + 89

        Form_mbslave.tab_endereco_leitura_91.Text = Form_mbslave.tab_leitura_inicio.Value + 90
        Form_mbslave.tab_endereco_leitura_92.Text = Form_mbslave.tab_leitura_inicio.Value + 91
        Form_mbslave.tab_endereco_leitura_93.Text = Form_mbslave.tab_leitura_inicio.Value + 92
        Form_mbslave.tab_endereco_leitura_94.Text = Form_mbslave.tab_leitura_inicio.Value + 93
        Form_mbslave.tab_endereco_leitura_95.Text = Form_mbslave.tab_leitura_inicio.Value + 94
        Form_mbslave.tab_endereco_leitura_96.Text = Form_mbslave.tab_leitura_inicio.Value + 95
        Form_mbslave.tab_endereco_leitura_97.Text = Form_mbslave.tab_leitura_inicio.Value + 96
        Form_mbslave.tab_endereco_leitura_98.Text = Form_mbslave.tab_leitura_inicio.Value + 97
        Form_mbslave.tab_endereco_leitura_99.Text = Form_mbslave.tab_leitura_inicio.Value + 98
        Form_mbslave.tab_endereco_leitura_100.Text = Form_mbslave.tab_leitura_inicio.Value + 99

    End Sub

    Public Sub apresentaValorTabelaLeitura()

        Form_mbslave.tab_valor_leitura_1.Text = string_leitura(0)
        Form_mbslave.tab_valor_leitura_2.Text = string_leitura(1)
        Form_mbslave.tab_valor_leitura_3.Text = string_leitura(2)
        Form_mbslave.tab_valor_leitura_4.Text = string_leitura(3)
        Form_mbslave.tab_valor_leitura_5.Text = string_leitura(4)
        Form_mbslave.tab_valor_leitura_6.Text = string_leitura(5)
        Form_mbslave.tab_valor_leitura_7.Text = string_leitura(6)
        Form_mbslave.tab_valor_leitura_8.Text = string_leitura(7)
        Form_mbslave.tab_valor_leitura_9.Text = string_leitura(8)
        Form_mbslave.tab_valor_leitura_10.Text = string_leitura(9)

        Form_mbslave.tab_valor_leitura_11.Text = string_leitura(10)
        Form_mbslave.tab_valor_leitura_12.Text = string_leitura(11)
        Form_mbslave.tab_valor_leitura_13.Text = string_leitura(12)
        Form_mbslave.tab_valor_leitura_14.Text = string_leitura(13)
        Form_mbslave.tab_valor_leitura_15.Text = string_leitura(14)
        Form_mbslave.tab_valor_leitura_16.Text = string_leitura(15)
        Form_mbslave.tab_valor_leitura_17.Text = string_leitura(16)
        Form_mbslave.tab_valor_leitura_18.Text = string_leitura(17)
        Form_mbslave.tab_valor_leitura_19.Text = string_leitura(18)
        Form_mbslave.tab_valor_leitura_20.Text = string_leitura(19)

        Form_mbslave.tab_valor_leitura_21.Text = string_leitura(20)
        Form_mbslave.tab_valor_leitura_22.Text = string_leitura(21)
        Form_mbslave.tab_valor_leitura_23.Text = string_leitura(22)
        Form_mbslave.tab_valor_leitura_24.Text = string_leitura(23)
        Form_mbslave.tab_valor_leitura_25.Text = string_leitura(24)
        Form_mbslave.tab_valor_leitura_26.Text = string_leitura(25)
        Form_mbslave.tab_valor_leitura_27.Text = string_leitura(26)
        Form_mbslave.tab_valor_leitura_28.Text = string_leitura(27)
        Form_mbslave.tab_valor_leitura_29.Text = string_leitura(28)
        Form_mbslave.tab_valor_leitura_30.Text = string_leitura(29)

        Form_mbslave.tab_valor_leitura_31.Text = string_leitura(30)
        Form_mbslave.tab_valor_leitura_32.Text = string_leitura(31)
        Form_mbslave.tab_valor_leitura_33.Text = string_leitura(32)
        Form_mbslave.tab_valor_leitura_34.Text = string_leitura(33)
        Form_mbslave.tab_valor_leitura_35.Text = string_leitura(34)
        Form_mbslave.tab_valor_leitura_36.Text = string_leitura(35)
        Form_mbslave.tab_valor_leitura_37.Text = string_leitura(36)
        Form_mbslave.tab_valor_leitura_38.Text = string_leitura(37)
        Form_mbslave.tab_valor_leitura_39.Text = string_leitura(38)
        Form_mbslave.tab_valor_leitura_40.Text = string_leitura(39)

        Form_mbslave.tab_valor_leitura_41.Text = string_leitura(40)
        Form_mbslave.tab_valor_leitura_42.Text = string_leitura(41)
        Form_mbslave.tab_valor_leitura_43.Text = string_leitura(42)
        Form_mbslave.tab_valor_leitura_44.Text = string_leitura(43)
        Form_mbslave.tab_valor_leitura_45.Text = string_leitura(44)
        Form_mbslave.tab_valor_leitura_46.Text = string_leitura(45)
        Form_mbslave.tab_valor_leitura_47.Text = string_leitura(46)
        Form_mbslave.tab_valor_leitura_48.Text = string_leitura(47)
        Form_mbslave.tab_valor_leitura_49.Text = string_leitura(48)
        Form_mbslave.tab_valor_leitura_50.Text = string_leitura(49)

        Form_mbslave.tab_valor_leitura_51.Text = string_leitura(50)
        Form_mbslave.tab_valor_leitura_52.Text = string_leitura(51)
        Form_mbslave.tab_valor_leitura_53.Text = string_leitura(52)
        Form_mbslave.tab_valor_leitura_54.Text = string_leitura(53)
        Form_mbslave.tab_valor_leitura_55.Text = string_leitura(54)
        Form_mbslave.tab_valor_leitura_56.Text = string_leitura(55)
        Form_mbslave.tab_valor_leitura_57.Text = string_leitura(56)
        Form_mbslave.tab_valor_leitura_58.Text = string_leitura(57)
        Form_mbslave.tab_valor_leitura_59.Text = string_leitura(58)
        Form_mbslave.tab_valor_leitura_60.Text = string_leitura(59)

        Form_mbslave.tab_valor_leitura_61.Text = string_leitura(60)
        Form_mbslave.tab_valor_leitura_62.Text = string_leitura(61)
        Form_mbslave.tab_valor_leitura_63.Text = string_leitura(62)
        Form_mbslave.tab_valor_leitura_64.Text = string_leitura(63)
        Form_mbslave.tab_valor_leitura_65.Text = string_leitura(64)
        Form_mbslave.tab_valor_leitura_66.Text = string_leitura(65)
        Form_mbslave.tab_valor_leitura_67.Text = string_leitura(66)
        Form_mbslave.tab_valor_leitura_68.Text = string_leitura(67)
        Form_mbslave.tab_valor_leitura_69.Text = string_leitura(68)
        Form_mbslave.tab_valor_leitura_70.Text = string_leitura(69)

        Form_mbslave.tab_valor_leitura_71.Text = string_leitura(70)
        Form_mbslave.tab_valor_leitura_72.Text = string_leitura(71)
        Form_mbslave.tab_valor_leitura_73.Text = string_leitura(72)
        Form_mbslave.tab_valor_leitura_74.Text = string_leitura(73)
        Form_mbslave.tab_valor_leitura_75.Text = string_leitura(74)
        Form_mbslave.tab_valor_leitura_76.Text = string_leitura(75)
        Form_mbslave.tab_valor_leitura_77.Text = string_leitura(76)
        Form_mbslave.tab_valor_leitura_78.Text = string_leitura(77)
        Form_mbslave.tab_valor_leitura_79.Text = string_leitura(78)
        Form_mbslave.tab_valor_leitura_80.Text = string_leitura(79)

        Form_mbslave.tab_valor_leitura_81.Text = string_leitura(80)
        Form_mbslave.tab_valor_leitura_82.Text = string_leitura(81)
        Form_mbslave.tab_valor_leitura_83.Text = string_leitura(82)
        Form_mbslave.tab_valor_leitura_84.Text = string_leitura(83)
        Form_mbslave.tab_valor_leitura_85.Text = string_leitura(84)
        Form_mbslave.tab_valor_leitura_86.Text = string_leitura(85)
        Form_mbslave.tab_valor_leitura_87.Text = string_leitura(86)
        Form_mbslave.tab_valor_leitura_88.Text = string_leitura(87)
        Form_mbslave.tab_valor_leitura_89.Text = string_leitura(88)
        Form_mbslave.tab_valor_leitura_90.Text = string_leitura(89)

        Form_mbslave.tab_valor_leitura_91.Text = string_leitura(90)
        Form_mbslave.tab_valor_leitura_92.Text = string_leitura(91)
        Form_mbslave.tab_valor_leitura_93.Text = string_leitura(92)
        Form_mbslave.tab_valor_leitura_94.Text = string_leitura(93)
        Form_mbslave.tab_valor_leitura_95.Text = string_leitura(94)
        Form_mbslave.tab_valor_leitura_96.Text = string_leitura(95)
        Form_mbslave.tab_valor_leitura_97.Text = string_leitura(96)
        Form_mbslave.tab_valor_leitura_98.Text = string_leitura(97)
        Form_mbslave.tab_valor_leitura_99.Text = string_leitura(98)
        Form_mbslave.tab_valor_leitura_100.Text = string_leitura(99)

    End Sub

    Public Function string_leitura(ByVal pos As Byte)

        Dim str As String
        Dim fim_tab As Long

        fim_tab = Form_mbslave.reg_leitura_inicio_memo + Form_mbslave.reg_leitura_tamanho_memo - Form_mbslave.tab_leitura_inicio.Value

        If fim_tab > pos Then
            str = input_register(deslocamento_leitura + pos)
        Else
            str = ""
        End If

        Return str
    End Function

    Public Sub apresentaSelecaoTabelaLeitura()

        If Form_mbslave.tab_leitura_inicio.Value + reg_select > Form_mbslave.reg_leitura_inicio_memo + Form_mbslave.reg_leitura_tamanho_memo Then
            reg_select = 0
        End If

        If reg_select > 0 Then
            Form_mbslave.Panel_leitura.Visible = True
            Form_mbslave.reg_sel.Text = (reg_select - 1) + Form_mbslave.tab_leitura_inicio.Value
            Form_mbslave.valor_sel.Value = input_register((reg_select - 1) + deslocamento_leitura)

            If input_register_status((reg_select - 1) + deslocamento_leitura) = 0 Then
                Form_mbslave.RadioButton_Normal.Checked = True
            ElseIf input_register_status((reg_select - 1) + deslocamento_leitura) = 1 Then
                Form_mbslave.RadioButton_Incrementa.Checked = True
            Else
                Form_mbslave.RadioButton_decrementa.Checked = True
            End If

        Else
            Form_mbslave.Panel_leitura.Visible = False
        End If

    End Sub
End Module
