<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_mbslave
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_mbslave))
        Me.Grupo_1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.velocidade = New System.Windows.Forms.ComboBox()
        Me.bt_Sair = New System.Windows.Forms.Button()
        Me.cb_Endereco = New System.Windows.Forms.ComboBox()
        Me.bt_at_port = New System.Windows.Forms.Button()
        Me.bt_Conect = New System.Windows.Forms.Button()
        Me.ComboBox_AvailableSerialPorts = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Grupo_2 = New System.Windows.Forms.GroupBox()
        Me.TB_serial_transacoes = New System.Windows.Forms.TextBox()
        Me.Reset_cont_erro_serial = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TB_serial_erro_endereco = New System.Windows.Forms.TextBox()
        Me.TB_serial_erro_crc = New System.Windows.Forms.TextBox()
        Me.TB_serial_exception_2 = New System.Windows.Forms.TextBox()
        Me.TB_serial_exception_1 = New System.Windows.Forms.TextBox()
        Me.TB_serial_erro_total = New System.Windows.Forms.TextBox()
        Me.LB_versao = New System.Windows.Forms.Label()
        Me.spModBus = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_frame = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Config = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BT_escrita_entra = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.reg_escrita_inicio = New System.Windows.Forms.NumericUpDown()
        Me.reg_escrita_tamanho = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_leitura_entra = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.reg_leitura_inicio = New System.Windows.Forms.NumericUpDown()
        Me.reg_leitura_tamanho = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Leitura = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tab_endereco_leitura_1 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_2 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_3 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_4 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_5 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_6 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_7 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_8 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_9 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_10 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_11 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_12 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_13 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_14 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_15 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_16 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_17 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_18 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_19 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_20 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_21 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_22 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_23 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_24 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_25 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_26 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_27 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_28 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_29 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_30 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_31 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_32 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_33 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_34 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_35 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_36 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_37 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_38 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_39 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_40 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_41 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_42 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_43 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_44 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_45 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_46 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_47 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_48 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_49 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_50 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_51 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_52 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_53 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_54 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_55 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_56 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_57 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_58 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_59 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_60 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_61 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_62 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_63 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_64 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_65 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_66 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_67 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_68 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_69 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_70 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_71 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_72 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_73 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_74 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_75 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_76 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_77 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_78 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_79 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_80 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_81 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_82 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_83 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_84 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_85 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_86 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_87 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_88 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_89 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_90 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_91 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_92 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_93 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_94 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_95 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_96 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_97 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_98 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_99 = New System.Windows.Forms.Label()
        Me.tab_endereco_leitura_100 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_1 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_2 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_3 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_4 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_5 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_6 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_7 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_8 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_9 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_10 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_11 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_12 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_13 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_14 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_15 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_16 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_17 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_18 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_19 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_20 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_21 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_22 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_23 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_24 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_25 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_26 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_27 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_28 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_29 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_30 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_31 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_32 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_33 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_34 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_35 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_36 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_37 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_38 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_39 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_40 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_41 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_42 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_43 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_44 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_45 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_46 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_47 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_48 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_49 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_50 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_51 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_52 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_53 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_54 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_55 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_56 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_57 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_58 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_59 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_60 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_61 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_62 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_63 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_64 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_65 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_66 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_67 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_68 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_69 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_70 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_71 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_72 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_73 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_74 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_75 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_76 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_77 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_78 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_79 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_80 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_83 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_84 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_85 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_86 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_87 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_88 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_89 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_90 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_91 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_92 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_93 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_94 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_95 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_96 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_97 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_98 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_99 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_100 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_81 = New System.Windows.Forms.Label()
        Me.tab_valor_leitura_82 = New System.Windows.Forms.Label()
        Me.Panel_leitura = New System.Windows.Forms.Panel()
        Me.BT_entra_sel = New System.Windows.Forms.Button()
        Me.BT_fecha = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.reg_sel = New System.Windows.Forms.Label()
        Me.valor_sel = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton_decrementa = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Normal = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Incrementa = New System.Windows.Forms.RadioButton()
        Me.tab_leitura_inicio = New System.Windows.Forms.NumericUpDown()
        Me.Escrita = New System.Windows.Forms.TabPage()
        Me.Label216 = New System.Windows.Forms.Label()
        Me.tab_escrita_inicio = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tab_endereco_escrita_1 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_2 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_3 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_4 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_5 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_6 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_7 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_8 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_9 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_10 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_11 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_12 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_13 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_14 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_15 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_16 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_17 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_18 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_19 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_20 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_21 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_22 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_23 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_24 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_25 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_26 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_27 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_28 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_29 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_30 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_31 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_32 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_33 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_34 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_35 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_36 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_37 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_38 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_39 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_40 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_41 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_42 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_43 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_44 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_45 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_46 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_47 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_48 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_49 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_50 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_51 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_52 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_53 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_54 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_55 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_56 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_57 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_58 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_59 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_60 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_61 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_62 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_63 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_64 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_65 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_66 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_67 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_68 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_69 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_70 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_71 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_72 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_73 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_74 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_75 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_76 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_77 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_78 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_79 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_80 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_81 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_82 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_83 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_84 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_85 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_86 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_87 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_88 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_89 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_90 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_91 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_92 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_93 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_94 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_95 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_96 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_97 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_98 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_99 = New System.Windows.Forms.Label()
        Me.tab_endereco_escrita_100 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_1 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_2 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_3 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_4 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_5 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_6 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_7 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_8 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_9 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_10 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_11 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_12 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_13 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_14 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_15 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_16 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_17 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_18 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_19 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_20 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_21 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_22 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_23 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_24 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_25 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_26 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_27 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_28 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_29 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_30 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_31 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_32 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_33 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_34 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_35 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_36 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_37 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_38 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_39 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_40 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_41 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_42 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_43 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_44 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_45 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_46 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_47 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_48 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_49 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_50 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_51 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_52 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_53 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_54 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_55 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_56 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_57 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_58 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_59 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_60 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_61 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_62 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_63 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_64 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_65 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_66 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_67 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_68 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_69 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_70 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_71 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_72 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_73 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_74 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_75 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_76 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_77 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_78 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_79 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_80 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_81 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_82 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_83 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_84 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_85 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_86 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_87 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_88 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_89 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_90 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_91 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_92 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_93 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_94 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_95 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_96 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_97 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_98 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_99 = New System.Windows.Forms.Label()
        Me.tab_valor_escrita_100 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Grupo_1.SuspendLayout
        Me.Grupo_2.SuspendLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl1.SuspendLayout
        Me.Config.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.reg_escrita_inicio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.reg_escrita_tamanho, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.reg_leitura_inicio, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.reg_leitura_tamanho, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Leitura.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel_leitura.SuspendLayout
        CType(Me.valor_sel, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tab_leitura_inicio, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Escrita.SuspendLayout
        CType(Me.tab_escrita_inicio, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'Grupo_1
        '
        Me.Grupo_1.Controls.Add(Me.Label12)
        Me.Grupo_1.Controls.Add(Me.velocidade)
        Me.Grupo_1.Controls.Add(Me.bt_Sair)
        Me.Grupo_1.Controls.Add(Me.cb_Endereco)
        Me.Grupo_1.Controls.Add(Me.bt_at_port)
        Me.Grupo_1.Controls.Add(Me.bt_Conect)
        Me.Grupo_1.Controls.Add(Me.ComboBox_AvailableSerialPorts)
        Me.Grupo_1.Controls.Add(Me.Label8)
        Me.Grupo_1.Controls.Add(Me.Label7)
        Me.Grupo_1.Location = New System.Drawing.Point(52, 28)
        Me.Grupo_1.Margin = New System.Windows.Forms.Padding(4)
        Me.Grupo_1.Name = "Grupo_1"
        Me.Grupo_1.Padding = New System.Windows.Forms.Padding(4)
        Me.Grupo_1.Size = New System.Drawing.Size(253, 341)
        Me.Grupo_1.TabIndex = 2231
        Me.Grupo_1.TabStop = False
        Me.Grupo_1.Text = "  Porta Serial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Location = New System.Drawing.Point(26, 76)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 2520
        Me.Label12.Text = "Taxa"
        '
        'velocidade
        '
        Me.velocidade.FormattingEnabled = True
        Me.velocidade.Items.AddRange(New Object() {"1200", "2400", "9600", "19200", "115200"})
        Me.velocidade.Location = New System.Drawing.Point(29, 97)
        Me.velocidade.Margin = New System.Windows.Forms.Padding(4)
        Me.velocidade.Name = "velocidade"
        Me.velocidade.Size = New System.Drawing.Size(81, 24)
        Me.velocidade.TabIndex = 2519
        '
        'bt_Sair
        '
        Me.bt_Sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Sair.Location = New System.Drawing.Point(151, 135)
        Me.bt_Sair.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Sair.Name = "bt_Sair"
        Me.bt_Sair.Size = New System.Drawing.Size(73, 39)
        Me.bt_Sair.TabIndex = 2169
        Me.bt_Sair.Text = "Sair"
        Me.bt_Sair.UseVisualStyleBackColor = True
        '
        'cb_Endereco
        '
        Me.cb_Endereco.FormattingEnabled = True
        Me.cb_Endereco.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb_Endereco.Location = New System.Drawing.Point(151, 48)
        Me.cb_Endereco.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Endereco.Name = "cb_Endereco"
        Me.cb_Endereco.Size = New System.Drawing.Size(72, 24)
        Me.cb_Endereco.TabIndex = 2165
        '
        'bt_at_port
        '
        Me.bt_at_port.Location = New System.Drawing.Point(116, 48)
        Me.bt_at_port.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_at_port.Name = "bt_at_port"
        Me.bt_at_port.Size = New System.Drawing.Size(27, 26)
        Me.bt_at_port.TabIndex = 2167
        Me.bt_at_port.UseVisualStyleBackColor = True
        '
        'bt_Conect
        '
        Me.bt_Conect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Conect.Location = New System.Drawing.Point(29, 134)
        Me.bt_Conect.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Conect.Name = "bt_Conect"
        Me.bt_Conect.Size = New System.Drawing.Size(112, 41)
        Me.bt_Conect.TabIndex = 2168
        Me.bt_Conect.Text = "Conect"
        Me.bt_Conect.UseVisualStyleBackColor = True
        '
        'ComboBox_AvailableSerialPorts
        '
        Me.ComboBox_AvailableSerialPorts.FormattingEnabled = True
        Me.ComboBox_AvailableSerialPorts.Location = New System.Drawing.Point(29, 48)
        Me.ComboBox_AvailableSerialPorts.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_AvailableSerialPorts.Name = "ComboBox_AvailableSerialPorts"
        Me.ComboBox_AvailableSerialPorts.Size = New System.Drawing.Size(81, 24)
        Me.ComboBox_AvailableSerialPorts.TabIndex = 2164
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(149, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 2223
        Me.Label8.Text = "Endereço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(26, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 2223
        Me.Label7.Text = "Porta"
        '
        'Grupo_2
        '
        Me.Grupo_2.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_2.Controls.Add(Me.TB_serial_transacoes)
        Me.Grupo_2.Controls.Add(Me.Reset_cont_erro_serial)
        Me.Grupo_2.Controls.Add(Me.Label10)
        Me.Grupo_2.Controls.Add(Me.Label3)
        Me.Grupo_2.Controls.Add(Me.Label11)
        Me.Grupo_2.Controls.Add(Me.Label72)
        Me.Grupo_2.Controls.Add(Me.Label70)
        Me.Grupo_2.Controls.Add(Me.Label69)
        Me.Grupo_2.Controls.Add(Me.Label1)
        Me.Grupo_2.Controls.Add(Me.Label68)
        Me.Grupo_2.Controls.Add(Me.Label71)
        Me.Grupo_2.Controls.Add(Me.TB_serial_erro_endereco)
        Me.Grupo_2.Controls.Add(Me.TB_serial_erro_crc)
        Me.Grupo_2.Controls.Add(Me.TB_serial_exception_2)
        Me.Grupo_2.Controls.Add(Me.TB_serial_exception_1)
        Me.Grupo_2.Controls.Add(Me.TB_serial_erro_total)
        Me.Grupo_2.Location = New System.Drawing.Point(333, 28)
        Me.Grupo_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Grupo_2.Name = "Grupo_2"
        Me.Grupo_2.Padding = New System.Windows.Forms.Padding(4)
        Me.Grupo_2.Size = New System.Drawing.Size(271, 341)
        Me.Grupo_2.TabIndex = 2401
        Me.Grupo_2.TabStop = False
        Me.Grupo_2.Text = " Comunicação "
        '
        'TB_serial_transacoes
        '
        Me.TB_serial_transacoes.Location = New System.Drawing.Point(111, 238)
        Me.TB_serial_transacoes.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_serial_transacoes.Name = "TB_serial_transacoes"
        Me.TB_serial_transacoes.Size = New System.Drawing.Size(119, 22)
        Me.TB_serial_transacoes.TabIndex = 2398
        '
        'Reset_cont_erro_serial
        '
        Me.Reset_cont_erro_serial.Location = New System.Drawing.Point(204, 198)
        Me.Reset_cont_erro_serial.Margin = New System.Windows.Forms.Padding(4)
        Me.Reset_cont_erro_serial.Name = "Reset_cont_erro_serial"
        Me.Reset_cont_erro_serial.Size = New System.Drawing.Size(27, 26)
        Me.Reset_cont_erro_serial.TabIndex = 2203
        Me.Reset_cont_erro_serial.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(19, 206)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 2202
        Me.Label10.Text = "Exception 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(19, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2202
        Me.Label3.Text = "Exception 1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(91, 305)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 2202
        Me.Label11.Text = "115200 8N1"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label72.Location = New System.Drawing.Point(24, 242)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(75, 17)
        Me.Label72.TabIndex = 2202
        Me.Label72.Text = "Trasações"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label70.Location = New System.Drawing.Point(29, 139)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(71, 17)
        Me.Label70.TabIndex = 2202
        Me.Label70.Text = "Total Erro"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label69.Location = New System.Drawing.Point(64, 106)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(36, 17)
        Me.Label69.TabIndex = 2202
        Me.Label69.Text = "CRC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(125, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 2202
        Me.Label1.Text = "Erros"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label68.Location = New System.Drawing.Point(39, 73)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(69, 17)
        Me.Label68.TabIndex = 2202
        Me.Label68.Text = "Endereço"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label71.Location = New System.Drawing.Point(195, 175)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(45, 17)
        Me.Label71.TabIndex = 2202
        Me.Label71.Text = "Reset"
        '
        'TB_serial_erro_endereco
        '
        Me.TB_serial_erro_endereco.Location = New System.Drawing.Point(113, 69)
        Me.TB_serial_erro_endereco.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_serial_erro_endereco.Name = "TB_serial_erro_endereco"
        Me.TB_serial_erro_endereco.Size = New System.Drawing.Size(71, 22)
        Me.TB_serial_erro_endereco.TabIndex = 2172
        '
        'TB_serial_erro_crc
        '
        Me.TB_serial_erro_crc.Location = New System.Drawing.Point(113, 102)
        Me.TB_serial_erro_crc.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_serial_erro_crc.Name = "TB_serial_erro_crc"
        Me.TB_serial_erro_crc.Size = New System.Drawing.Size(71, 22)
        Me.TB_serial_erro_crc.TabIndex = 2172
        '
        'TB_serial_exception_2
        '
        Me.TB_serial_exception_2.Location = New System.Drawing.Point(113, 202)
        Me.TB_serial_exception_2.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_serial_exception_2.Name = "TB_serial_exception_2"
        Me.TB_serial_exception_2.Size = New System.Drawing.Size(71, 22)
        Me.TB_serial_exception_2.TabIndex = 2172
        '
        'TB_serial_exception_1
        '
        Me.TB_serial_exception_1.Location = New System.Drawing.Point(113, 170)
        Me.TB_serial_exception_1.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_serial_exception_1.Name = "TB_serial_exception_1"
        Me.TB_serial_exception_1.Size = New System.Drawing.Size(71, 22)
        Me.TB_serial_exception_1.TabIndex = 2172
        '
        'TB_serial_erro_total
        '
        Me.TB_serial_erro_total.Location = New System.Drawing.Point(113, 135)
        Me.TB_serial_erro_total.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_serial_erro_total.Name = "TB_serial_erro_total"
        Me.TB_serial_erro_total.Size = New System.Drawing.Size(71, 22)
        Me.TB_serial_erro_total.TabIndex = 2172
        '
        'LB_versao
        '
        Me.LB_versao.AutoSize = True
        Me.LB_versao.Location = New System.Drawing.Point(1227, 119)
        Me.LB_versao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_versao.Name = "LB_versao"
        Me.LB_versao.Size = New System.Drawing.Size(53, 17)
        Me.LB_versao.TabIndex = 2402
        Me.LB_versao.Text = "Versão"
        '
        'spModBus
        '
        Me.spModBus.BaudRate = 115200
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Timer_frame
        '
        Me.Timer_frame.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.cpqd
        Me.PictureBox1.Location = New System.Drawing.Point(1159, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2404
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.Config)
        Me.TabControl1.Controls.Add(Me.Leitura)
        Me.TabControl1.Controls.Add(Me.Escrita)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1412, 823)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 2518
        '
        'Config
        '
        Me.Config.BackColor = System.Drawing.Color.White
        Me.Config.Controls.Add(Me.GroupBox2)
        Me.Config.Controls.Add(Me.GroupBox1)
        Me.Config.Controls.Add(Me.Grupo_2)
        Me.Config.Controls.Add(Me.Grupo_1)
        Me.Config.Controls.Add(Me.PictureBox1)
        Me.Config.Controls.Add(Me.LB_versao)
        Me.Config.Location = New System.Drawing.Point(4, 28)
        Me.Config.Margin = New System.Windows.Forms.Padding(4)
        Me.Config.Name = "Config"
        Me.Config.Padding = New System.Windows.Forms.Padding(4)
        Me.Config.Size = New System.Drawing.Size(1404, 791)
        Me.Config.TabIndex = 0
        Me.Config.Text = "Configuração"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BT_escrita_entra)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.reg_escrita_inicio)
        Me.GroupBox2.Controls.Add(Me.reg_escrita_tamanho)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(684, 224)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(269, 145)
        Me.GroupBox2.TabIndex = 2523
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Registros Escrita "
        '
        'BT_escrita_entra
        '
        Me.BT_escrita_entra.Location = New System.Drawing.Point(152, 105)
        Me.BT_escrita_entra.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_escrita_entra.Name = "BT_escrita_entra"
        Me.BT_escrita_entra.Size = New System.Drawing.Size(77, 26)
        Me.BT_escrita_entra.TabIndex = 2515
        Me.BT_escrita_entra.Text = "Entra"
        Me.BT_escrita_entra.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(24, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 20)
        Me.Label14.TabIndex = 2514
        Me.Label14.Text = "Tamannho"
        '
        'reg_escrita_inicio
        '
        Me.reg_escrita_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reg_escrita_inicio.Location = New System.Drawing.Point(152, 30)
        Me.reg_escrita_inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.reg_escrita_inicio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.reg_escrita_inicio.Name = "reg_escrita_inicio"
        Me.reg_escrita_inicio.Size = New System.Drawing.Size(77, 22)
        Me.reg_escrita_inicio.TabIndex = 2512
        '
        'reg_escrita_tamanho
        '
        Me.reg_escrita_tamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reg_escrita_tamanho.Location = New System.Drawing.Point(152, 68)
        Me.reg_escrita_tamanho.Margin = New System.Windows.Forms.Padding(4)
        Me.reg_escrita_tamanho.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.reg_escrita_tamanho.Name = "reg_escrita_tamanho"
        Me.reg_escrita_tamanho.Size = New System.Drawing.Size(77, 22)
        Me.reg_escrita_tamanho.TabIndex = 2512
        Me.reg_escrita_tamanho.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(72, 33)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 20)
        Me.Label16.TabIndex = 2514
        Me.Label16.Text = "Inicio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_leitura_entra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.reg_leitura_inicio)
        Me.GroupBox1.Controls.Add(Me.reg_leitura_tamanho)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(271, 151)
        Me.GroupBox1.TabIndex = 2522
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros Leitura "
        '
        'BT_leitura_entra
        '
        Me.BT_leitura_entra.Location = New System.Drawing.Point(152, 111)
        Me.BT_leitura_entra.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_leitura_entra.Name = "BT_leitura_entra"
        Me.BT_leitura_entra.Size = New System.Drawing.Size(77, 26)
        Me.BT_leitura_entra.TabIndex = 2515
        Me.BT_leitura_entra.Text = "Entra"
        Me.BT_leitura_entra.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(24, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 2514
        Me.Label5.Text = "Tamannho"
        '
        'reg_leitura_inicio
        '
        Me.reg_leitura_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reg_leitura_inicio.Location = New System.Drawing.Point(152, 34)
        Me.reg_leitura_inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.reg_leitura_inicio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.reg_leitura_inicio.Name = "reg_leitura_inicio"
        Me.reg_leitura_inicio.Size = New System.Drawing.Size(77, 22)
        Me.reg_leitura_inicio.TabIndex = 2512
        '
        'reg_leitura_tamanho
        '
        Me.reg_leitura_tamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reg_leitura_tamanho.Location = New System.Drawing.Point(152, 73)
        Me.reg_leitura_tamanho.Margin = New System.Windows.Forms.Padding(4)
        Me.reg_leitura_tamanho.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.reg_leitura_tamanho.Name = "reg_leitura_tamanho"
        Me.reg_leitura_tamanho.Size = New System.Drawing.Size(77, 22)
        Me.reg_leitura_tamanho.TabIndex = 2512
        Me.reg_leitura_tamanho.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(72, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 2514
        Me.Label4.Text = "Inicio"
        '
        'Leitura
        '
        Me.Leitura.AllowDrop = True
        Me.Leitura.BackColor = System.Drawing.Color.White
        Me.Leitura.Controls.Add(Me.Label6)
        Me.Leitura.Controls.Add(Me.TableLayoutPanel1)
        Me.Leitura.Controls.Add(Me.Panel_leitura)
        Me.Leitura.Controls.Add(Me.tab_leitura_inicio)
        Me.Leitura.Location = New System.Drawing.Point(4, 28)
        Me.Leitura.Margin = New System.Windows.Forms.Padding(4)
        Me.Leitura.Name = "Leitura"
        Me.Leitura.Padding = New System.Windows.Forms.Padding(4)
        Me.Leitura.Size = New System.Drawing.Size(1404, 791)
        Me.Leitura.TabIndex = 1
        Me.Leitura.Text = "Leitura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 2522
        Me.Label6.Text = "Inicio"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AllowDrop = True
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_10, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_11, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_12, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_13, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_14, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_15, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_16, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_17, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_18, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_19, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_20, 0, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_21, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_22, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_23, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_24, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_25, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_26, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_27, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_28, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_29, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_30, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_31, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_32, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_33, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_34, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_35, 2, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_36, 2, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_37, 2, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_38, 2, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_39, 2, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_40, 2, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_41, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_42, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_43, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_44, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_45, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_46, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_47, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_48, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_49, 4, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_50, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_51, 4, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_52, 4, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_53, 4, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_54, 4, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_55, 4, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_56, 4, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_57, 4, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_58, 4, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_59, 4, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_60, 4, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_61, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_62, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_63, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_64, 6, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_65, 6, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_66, 6, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_67, 6, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_68, 6, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_69, 6, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_70, 6, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_71, 6, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_72, 6, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_73, 6, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_74, 6, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_75, 6, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_76, 6, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_77, 6, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_78, 6, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_79, 6, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_80, 6, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_81, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_82, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_83, 8, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_84, 8, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_85, 8, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_86, 8, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_87, 8, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_88, 8, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_89, 8, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_90, 8, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_91, 8, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_92, 8, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_93, 8, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_94, 8, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_95, 8, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_96, 8, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_97, 8, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_98, 8, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_99, 8, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_endereco_leitura_100, 8, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_6, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_7, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_8, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_9, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_10, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_11, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_12, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_13, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_14, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_15, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_16, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_17, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_18, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_19, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_20, 1, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_21, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_22, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_23, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_24, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_25, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_26, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_27, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_28, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_29, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_30, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_31, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_32, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_33, 3, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_34, 3, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_35, 3, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_36, 3, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_37, 3, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_38, 3, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_39, 3, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_40, 3, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_41, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_42, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_43, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_44, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_45, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_46, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_47, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_48, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_49, 5, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_50, 5, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_51, 5, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_52, 5, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_53, 5, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_54, 5, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_55, 5, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_56, 5, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_57, 5, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_58, 5, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_59, 5, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_60, 5, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_61, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_62, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_63, 7, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_64, 7, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_65, 7, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_66, 7, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_67, 7, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_68, 7, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_69, 7, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_70, 7, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_71, 7, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_72, 7, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_73, 7, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_74, 7, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_75, 7, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_76, 7, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_77, 7, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_78, 7, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_79, 7, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_80, 7, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_83, 9, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_84, 9, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_85, 9, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_86, 9, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_87, 9, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_88, 9, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_89, 9, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_90, 9, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_91, 9, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_92, 9, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_93, 9, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_94, 9, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_95, 9, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_96, 9, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_97, 9, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_98, 9, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_99, 9, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_100, 9, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_81, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tab_valor_leitura_82, 9, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(31, 76)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 20
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1055, 574)
        Me.TableLayoutPanel1.TabIndex = 2521
        '
        'tab_endereco_leitura_1
        '
        Me.tab_endereco_leitura_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_1.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_1.CausesValidation = False
        Me.tab_endereco_leitura_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_1.Location = New System.Drawing.Point(7, 3)
        Me.tab_endereco_leitura_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_1.Name = "tab_endereco_leitura_1"
        Me.tab_endereco_leitura_1.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_1.TabIndex = 2519
        Me.tab_endereco_leitura_1.Text = "0"
        Me.tab_endereco_leitura_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_2
        '
        Me.tab_endereco_leitura_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_2.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_2.CausesValidation = False
        Me.tab_endereco_leitura_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_2.Location = New System.Drawing.Point(7, 31)
        Me.tab_endereco_leitura_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_2.Name = "tab_endereco_leitura_2"
        Me.tab_endereco_leitura_2.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_2.TabIndex = 2519
        Me.tab_endereco_leitura_2.Text = "0"
        Me.tab_endereco_leitura_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_3
        '
        Me.tab_endereco_leitura_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_3.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_3.CausesValidation = False
        Me.tab_endereco_leitura_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_3.Location = New System.Drawing.Point(7, 59)
        Me.tab_endereco_leitura_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_3.Name = "tab_endereco_leitura_3"
        Me.tab_endereco_leitura_3.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_3.TabIndex = 2519
        Me.tab_endereco_leitura_3.Text = "0"
        Me.tab_endereco_leitura_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_4
        '
        Me.tab_endereco_leitura_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_4.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_4.CausesValidation = False
        Me.tab_endereco_leitura_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_4.Location = New System.Drawing.Point(7, 87)
        Me.tab_endereco_leitura_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_4.Name = "tab_endereco_leitura_4"
        Me.tab_endereco_leitura_4.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_4.TabIndex = 2519
        Me.tab_endereco_leitura_4.Text = "0"
        Me.tab_endereco_leitura_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_5
        '
        Me.tab_endereco_leitura_5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_5.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_5.CausesValidation = False
        Me.tab_endereco_leitura_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_5.Location = New System.Drawing.Point(7, 115)
        Me.tab_endereco_leitura_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_5.Name = "tab_endereco_leitura_5"
        Me.tab_endereco_leitura_5.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_5.TabIndex = 2519
        Me.tab_endereco_leitura_5.Text = "0"
        Me.tab_endereco_leitura_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_6
        '
        Me.tab_endereco_leitura_6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_6.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_6.CausesValidation = False
        Me.tab_endereco_leitura_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_6.Location = New System.Drawing.Point(7, 143)
        Me.tab_endereco_leitura_6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_6.Name = "tab_endereco_leitura_6"
        Me.tab_endereco_leitura_6.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_6.TabIndex = 2519
        Me.tab_endereco_leitura_6.Text = "0"
        Me.tab_endereco_leitura_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_7
        '
        Me.tab_endereco_leitura_7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_7.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_7.CausesValidation = False
        Me.tab_endereco_leitura_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_7.Location = New System.Drawing.Point(7, 171)
        Me.tab_endereco_leitura_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_7.Name = "tab_endereco_leitura_7"
        Me.tab_endereco_leitura_7.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_7.TabIndex = 2519
        Me.tab_endereco_leitura_7.Text = "0"
        Me.tab_endereco_leitura_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_8
        '
        Me.tab_endereco_leitura_8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_8.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_8.CausesValidation = False
        Me.tab_endereco_leitura_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_8.Location = New System.Drawing.Point(7, 199)
        Me.tab_endereco_leitura_8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_8.Name = "tab_endereco_leitura_8"
        Me.tab_endereco_leitura_8.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_8.TabIndex = 2519
        Me.tab_endereco_leitura_8.Text = "0"
        Me.tab_endereco_leitura_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_9
        '
        Me.tab_endereco_leitura_9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_9.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_9.CausesValidation = False
        Me.tab_endereco_leitura_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_9.Location = New System.Drawing.Point(7, 227)
        Me.tab_endereco_leitura_9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_9.Name = "tab_endereco_leitura_9"
        Me.tab_endereco_leitura_9.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_9.TabIndex = 2519
        Me.tab_endereco_leitura_9.Text = "0"
        Me.tab_endereco_leitura_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_10
        '
        Me.tab_endereco_leitura_10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_10.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_10.CausesValidation = False
        Me.tab_endereco_leitura_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_10.Location = New System.Drawing.Point(7, 255)
        Me.tab_endereco_leitura_10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_10.Name = "tab_endereco_leitura_10"
        Me.tab_endereco_leitura_10.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_10.TabIndex = 2519
        Me.tab_endereco_leitura_10.Text = "0"
        Me.tab_endereco_leitura_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_11
        '
        Me.tab_endereco_leitura_11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_11.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_11.CausesValidation = False
        Me.tab_endereco_leitura_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_11.Location = New System.Drawing.Point(7, 283)
        Me.tab_endereco_leitura_11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_11.Name = "tab_endereco_leitura_11"
        Me.tab_endereco_leitura_11.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_11.TabIndex = 2519
        Me.tab_endereco_leitura_11.Text = "0"
        Me.tab_endereco_leitura_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_12
        '
        Me.tab_endereco_leitura_12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_12.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_12.CausesValidation = False
        Me.tab_endereco_leitura_12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_12.Location = New System.Drawing.Point(7, 311)
        Me.tab_endereco_leitura_12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_12.Name = "tab_endereco_leitura_12"
        Me.tab_endereco_leitura_12.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_12.TabIndex = 2519
        Me.tab_endereco_leitura_12.Text = "0"
        Me.tab_endereco_leitura_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_13
        '
        Me.tab_endereco_leitura_13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_13.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_13.CausesValidation = False
        Me.tab_endereco_leitura_13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_13.Location = New System.Drawing.Point(7, 339)
        Me.tab_endereco_leitura_13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_13.Name = "tab_endereco_leitura_13"
        Me.tab_endereco_leitura_13.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_13.TabIndex = 2519
        Me.tab_endereco_leitura_13.Text = "0"
        Me.tab_endereco_leitura_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_14
        '
        Me.tab_endereco_leitura_14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_14.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_14.CausesValidation = False
        Me.tab_endereco_leitura_14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_14.Location = New System.Drawing.Point(7, 367)
        Me.tab_endereco_leitura_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_14.Name = "tab_endereco_leitura_14"
        Me.tab_endereco_leitura_14.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_14.TabIndex = 2519
        Me.tab_endereco_leitura_14.Text = "0"
        Me.tab_endereco_leitura_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_15
        '
        Me.tab_endereco_leitura_15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_15.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_15.CausesValidation = False
        Me.tab_endereco_leitura_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_15.Location = New System.Drawing.Point(7, 395)
        Me.tab_endereco_leitura_15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_15.Name = "tab_endereco_leitura_15"
        Me.tab_endereco_leitura_15.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_15.TabIndex = 2519
        Me.tab_endereco_leitura_15.Text = "0"
        Me.tab_endereco_leitura_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_16
        '
        Me.tab_endereco_leitura_16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_16.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_16.CausesValidation = False
        Me.tab_endereco_leitura_16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_16.Location = New System.Drawing.Point(7, 423)
        Me.tab_endereco_leitura_16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_16.Name = "tab_endereco_leitura_16"
        Me.tab_endereco_leitura_16.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_16.TabIndex = 2519
        Me.tab_endereco_leitura_16.Text = "0"
        Me.tab_endereco_leitura_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_17
        '
        Me.tab_endereco_leitura_17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_17.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_17.CausesValidation = False
        Me.tab_endereco_leitura_17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_17.Location = New System.Drawing.Point(7, 451)
        Me.tab_endereco_leitura_17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_17.Name = "tab_endereco_leitura_17"
        Me.tab_endereco_leitura_17.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_17.TabIndex = 2519
        Me.tab_endereco_leitura_17.Text = "0"
        Me.tab_endereco_leitura_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_18
        '
        Me.tab_endereco_leitura_18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_18.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_18.CausesValidation = False
        Me.tab_endereco_leitura_18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_18.Location = New System.Drawing.Point(7, 479)
        Me.tab_endereco_leitura_18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_18.Name = "tab_endereco_leitura_18"
        Me.tab_endereco_leitura_18.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_18.TabIndex = 2519
        Me.tab_endereco_leitura_18.Text = "0"
        Me.tab_endereco_leitura_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_19
        '
        Me.tab_endereco_leitura_19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_19.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_19.CausesValidation = False
        Me.tab_endereco_leitura_19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_19.Location = New System.Drawing.Point(7, 507)
        Me.tab_endereco_leitura_19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_19.Name = "tab_endereco_leitura_19"
        Me.tab_endereco_leitura_19.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_19.TabIndex = 2519
        Me.tab_endereco_leitura_19.Text = "0"
        Me.tab_endereco_leitura_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_20
        '
        Me.tab_endereco_leitura_20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_20.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_20.CausesValidation = False
        Me.tab_endereco_leitura_20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_20.Location = New System.Drawing.Point(7, 540)
        Me.tab_endereco_leitura_20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_20.Name = "tab_endereco_leitura_20"
        Me.tab_endereco_leitura_20.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_20.TabIndex = 2519
        Me.tab_endereco_leitura_20.Text = "0"
        Me.tab_endereco_leitura_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_21
        '
        Me.tab_endereco_leitura_21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_21.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_21.CausesValidation = False
        Me.tab_endereco_leitura_21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_21.Location = New System.Drawing.Point(213, 3)
        Me.tab_endereco_leitura_21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_21.Name = "tab_endereco_leitura_21"
        Me.tab_endereco_leitura_21.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_21.TabIndex = 2519
        Me.tab_endereco_leitura_21.Text = "0"
        Me.tab_endereco_leitura_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_22
        '
        Me.tab_endereco_leitura_22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_22.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_22.CausesValidation = False
        Me.tab_endereco_leitura_22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_22.Location = New System.Drawing.Point(213, 31)
        Me.tab_endereco_leitura_22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_22.Name = "tab_endereco_leitura_22"
        Me.tab_endereco_leitura_22.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_22.TabIndex = 2519
        Me.tab_endereco_leitura_22.Text = "0"
        Me.tab_endereco_leitura_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_23
        '
        Me.tab_endereco_leitura_23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_23.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_23.CausesValidation = False
        Me.tab_endereco_leitura_23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_23.Location = New System.Drawing.Point(213, 59)
        Me.tab_endereco_leitura_23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_23.Name = "tab_endereco_leitura_23"
        Me.tab_endereco_leitura_23.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_23.TabIndex = 2519
        Me.tab_endereco_leitura_23.Text = "0"
        Me.tab_endereco_leitura_23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_24
        '
        Me.tab_endereco_leitura_24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_24.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_24.CausesValidation = False
        Me.tab_endereco_leitura_24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_24.Location = New System.Drawing.Point(213, 87)
        Me.tab_endereco_leitura_24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_24.Name = "tab_endereco_leitura_24"
        Me.tab_endereco_leitura_24.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_24.TabIndex = 2519
        Me.tab_endereco_leitura_24.Text = "0"
        Me.tab_endereco_leitura_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_25
        '
        Me.tab_endereco_leitura_25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_25.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_25.CausesValidation = False
        Me.tab_endereco_leitura_25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_25.Location = New System.Drawing.Point(213, 115)
        Me.tab_endereco_leitura_25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_25.Name = "tab_endereco_leitura_25"
        Me.tab_endereco_leitura_25.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_25.TabIndex = 2519
        Me.tab_endereco_leitura_25.Text = "0"
        Me.tab_endereco_leitura_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_26
        '
        Me.tab_endereco_leitura_26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_26.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_26.CausesValidation = False
        Me.tab_endereco_leitura_26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_26.Location = New System.Drawing.Point(213, 143)
        Me.tab_endereco_leitura_26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_26.Name = "tab_endereco_leitura_26"
        Me.tab_endereco_leitura_26.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_26.TabIndex = 2519
        Me.tab_endereco_leitura_26.Text = "0"
        Me.tab_endereco_leitura_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_27
        '
        Me.tab_endereco_leitura_27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_27.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_27.CausesValidation = False
        Me.tab_endereco_leitura_27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_27.Location = New System.Drawing.Point(213, 171)
        Me.tab_endereco_leitura_27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_27.Name = "tab_endereco_leitura_27"
        Me.tab_endereco_leitura_27.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_27.TabIndex = 2519
        Me.tab_endereco_leitura_27.Text = "0"
        Me.tab_endereco_leitura_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_28
        '
        Me.tab_endereco_leitura_28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_28.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_28.CausesValidation = False
        Me.tab_endereco_leitura_28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_28.Location = New System.Drawing.Point(213, 199)
        Me.tab_endereco_leitura_28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_28.Name = "tab_endereco_leitura_28"
        Me.tab_endereco_leitura_28.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_28.TabIndex = 2519
        Me.tab_endereco_leitura_28.Text = "0"
        Me.tab_endereco_leitura_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_29
        '
        Me.tab_endereco_leitura_29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_29.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_29.CausesValidation = False
        Me.tab_endereco_leitura_29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_29.Location = New System.Drawing.Point(213, 227)
        Me.tab_endereco_leitura_29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_29.Name = "tab_endereco_leitura_29"
        Me.tab_endereco_leitura_29.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_29.TabIndex = 2519
        Me.tab_endereco_leitura_29.Text = "0"
        Me.tab_endereco_leitura_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_30
        '
        Me.tab_endereco_leitura_30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_30.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_30.CausesValidation = False
        Me.tab_endereco_leitura_30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_30.Location = New System.Drawing.Point(213, 255)
        Me.tab_endereco_leitura_30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_30.Name = "tab_endereco_leitura_30"
        Me.tab_endereco_leitura_30.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_30.TabIndex = 2519
        Me.tab_endereco_leitura_30.Text = "0"
        Me.tab_endereco_leitura_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_31
        '
        Me.tab_endereco_leitura_31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_31.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_31.CausesValidation = False
        Me.tab_endereco_leitura_31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_31.Location = New System.Drawing.Point(213, 283)
        Me.tab_endereco_leitura_31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_31.Name = "tab_endereco_leitura_31"
        Me.tab_endereco_leitura_31.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_31.TabIndex = 2519
        Me.tab_endereco_leitura_31.Text = "0"
        Me.tab_endereco_leitura_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_32
        '
        Me.tab_endereco_leitura_32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_32.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_32.CausesValidation = False
        Me.tab_endereco_leitura_32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_32.Location = New System.Drawing.Point(213, 311)
        Me.tab_endereco_leitura_32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_32.Name = "tab_endereco_leitura_32"
        Me.tab_endereco_leitura_32.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_32.TabIndex = 2519
        Me.tab_endereco_leitura_32.Text = "0"
        Me.tab_endereco_leitura_32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_33
        '
        Me.tab_endereco_leitura_33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_33.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_33.CausesValidation = False
        Me.tab_endereco_leitura_33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_33.Location = New System.Drawing.Point(213, 339)
        Me.tab_endereco_leitura_33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_33.Name = "tab_endereco_leitura_33"
        Me.tab_endereco_leitura_33.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_33.TabIndex = 2519
        Me.tab_endereco_leitura_33.Text = "0"
        Me.tab_endereco_leitura_33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_34
        '
        Me.tab_endereco_leitura_34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_34.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_34.CausesValidation = False
        Me.tab_endereco_leitura_34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_34.Location = New System.Drawing.Point(213, 367)
        Me.tab_endereco_leitura_34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_34.Name = "tab_endereco_leitura_34"
        Me.tab_endereco_leitura_34.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_34.TabIndex = 2519
        Me.tab_endereco_leitura_34.Text = "0"
        Me.tab_endereco_leitura_34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_35
        '
        Me.tab_endereco_leitura_35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_35.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_35.CausesValidation = False
        Me.tab_endereco_leitura_35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_35.Location = New System.Drawing.Point(213, 395)
        Me.tab_endereco_leitura_35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_35.Name = "tab_endereco_leitura_35"
        Me.tab_endereco_leitura_35.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_35.TabIndex = 2519
        Me.tab_endereco_leitura_35.Text = "0"
        Me.tab_endereco_leitura_35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_36
        '
        Me.tab_endereco_leitura_36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_36.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_36.CausesValidation = False
        Me.tab_endereco_leitura_36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_36.Location = New System.Drawing.Point(213, 423)
        Me.tab_endereco_leitura_36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_36.Name = "tab_endereco_leitura_36"
        Me.tab_endereco_leitura_36.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_36.TabIndex = 2519
        Me.tab_endereco_leitura_36.Text = "0"
        Me.tab_endereco_leitura_36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_37
        '
        Me.tab_endereco_leitura_37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_37.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_37.CausesValidation = False
        Me.tab_endereco_leitura_37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_37.Location = New System.Drawing.Point(213, 451)
        Me.tab_endereco_leitura_37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_37.Name = "tab_endereco_leitura_37"
        Me.tab_endereco_leitura_37.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_37.TabIndex = 2519
        Me.tab_endereco_leitura_37.Text = "0"
        Me.tab_endereco_leitura_37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_38
        '
        Me.tab_endereco_leitura_38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_38.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_38.CausesValidation = False
        Me.tab_endereco_leitura_38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_38.Location = New System.Drawing.Point(213, 479)
        Me.tab_endereco_leitura_38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_38.Name = "tab_endereco_leitura_38"
        Me.tab_endereco_leitura_38.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_38.TabIndex = 2519
        Me.tab_endereco_leitura_38.Text = "0"
        Me.tab_endereco_leitura_38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_39
        '
        Me.tab_endereco_leitura_39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_39.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_39.CausesValidation = False
        Me.tab_endereco_leitura_39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_39.Location = New System.Drawing.Point(213, 507)
        Me.tab_endereco_leitura_39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_39.Name = "tab_endereco_leitura_39"
        Me.tab_endereco_leitura_39.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_39.TabIndex = 2519
        Me.tab_endereco_leitura_39.Text = "0"
        Me.tab_endereco_leitura_39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_40
        '
        Me.tab_endereco_leitura_40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_40.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_40.CausesValidation = False
        Me.tab_endereco_leitura_40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_40.Location = New System.Drawing.Point(213, 540)
        Me.tab_endereco_leitura_40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_40.Name = "tab_endereco_leitura_40"
        Me.tab_endereco_leitura_40.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_40.TabIndex = 2519
        Me.tab_endereco_leitura_40.Text = "0"
        Me.tab_endereco_leitura_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_41
        '
        Me.tab_endereco_leitura_41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_41.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_41.CausesValidation = False
        Me.tab_endereco_leitura_41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_41.Location = New System.Drawing.Point(419, 3)
        Me.tab_endereco_leitura_41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_41.Name = "tab_endereco_leitura_41"
        Me.tab_endereco_leitura_41.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_41.TabIndex = 2519
        Me.tab_endereco_leitura_41.Text = "0"
        Me.tab_endereco_leitura_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_42
        '
        Me.tab_endereco_leitura_42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_42.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_42.CausesValidation = False
        Me.tab_endereco_leitura_42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_42.Location = New System.Drawing.Point(419, 31)
        Me.tab_endereco_leitura_42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_42.Name = "tab_endereco_leitura_42"
        Me.tab_endereco_leitura_42.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_42.TabIndex = 2519
        Me.tab_endereco_leitura_42.Text = "0"
        Me.tab_endereco_leitura_42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_43
        '
        Me.tab_endereco_leitura_43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_43.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_43.CausesValidation = False
        Me.tab_endereco_leitura_43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_43.Location = New System.Drawing.Point(419, 59)
        Me.tab_endereco_leitura_43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_43.Name = "tab_endereco_leitura_43"
        Me.tab_endereco_leitura_43.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_43.TabIndex = 2519
        Me.tab_endereco_leitura_43.Text = "0"
        Me.tab_endereco_leitura_43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_44
        '
        Me.tab_endereco_leitura_44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_44.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_44.CausesValidation = False
        Me.tab_endereco_leitura_44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_44.Location = New System.Drawing.Point(419, 87)
        Me.tab_endereco_leitura_44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_44.Name = "tab_endereco_leitura_44"
        Me.tab_endereco_leitura_44.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_44.TabIndex = 2519
        Me.tab_endereco_leitura_44.Text = "0"
        Me.tab_endereco_leitura_44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_45
        '
        Me.tab_endereco_leitura_45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_45.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_45.CausesValidation = False
        Me.tab_endereco_leitura_45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_45.Location = New System.Drawing.Point(419, 115)
        Me.tab_endereco_leitura_45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_45.Name = "tab_endereco_leitura_45"
        Me.tab_endereco_leitura_45.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_45.TabIndex = 2519
        Me.tab_endereco_leitura_45.Text = "0"
        Me.tab_endereco_leitura_45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_46
        '
        Me.tab_endereco_leitura_46.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_46.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_46.CausesValidation = False
        Me.tab_endereco_leitura_46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_46.Location = New System.Drawing.Point(419, 143)
        Me.tab_endereco_leitura_46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_46.Name = "tab_endereco_leitura_46"
        Me.tab_endereco_leitura_46.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_46.TabIndex = 2519
        Me.tab_endereco_leitura_46.Text = "0"
        Me.tab_endereco_leitura_46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_47
        '
        Me.tab_endereco_leitura_47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_47.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_47.CausesValidation = False
        Me.tab_endereco_leitura_47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_47.Location = New System.Drawing.Point(419, 171)
        Me.tab_endereco_leitura_47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_47.Name = "tab_endereco_leitura_47"
        Me.tab_endereco_leitura_47.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_47.TabIndex = 2519
        Me.tab_endereco_leitura_47.Text = "0"
        Me.tab_endereco_leitura_47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_48
        '
        Me.tab_endereco_leitura_48.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_48.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_48.CausesValidation = False
        Me.tab_endereco_leitura_48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_48.Location = New System.Drawing.Point(419, 199)
        Me.tab_endereco_leitura_48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_48.Name = "tab_endereco_leitura_48"
        Me.tab_endereco_leitura_48.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_48.TabIndex = 2519
        Me.tab_endereco_leitura_48.Text = "0"
        Me.tab_endereco_leitura_48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_49
        '
        Me.tab_endereco_leitura_49.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_49.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_49.CausesValidation = False
        Me.tab_endereco_leitura_49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_49.Location = New System.Drawing.Point(419, 227)
        Me.tab_endereco_leitura_49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_49.Name = "tab_endereco_leitura_49"
        Me.tab_endereco_leitura_49.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_49.TabIndex = 2519
        Me.tab_endereco_leitura_49.Text = "0"
        Me.tab_endereco_leitura_49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_50
        '
        Me.tab_endereco_leitura_50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_50.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_50.CausesValidation = False
        Me.tab_endereco_leitura_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_50.Location = New System.Drawing.Point(419, 255)
        Me.tab_endereco_leitura_50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_50.Name = "tab_endereco_leitura_50"
        Me.tab_endereco_leitura_50.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_50.TabIndex = 2519
        Me.tab_endereco_leitura_50.Text = "0"
        Me.tab_endereco_leitura_50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_51
        '
        Me.tab_endereco_leitura_51.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_51.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_51.CausesValidation = False
        Me.tab_endereco_leitura_51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_51.Location = New System.Drawing.Point(419, 283)
        Me.tab_endereco_leitura_51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_51.Name = "tab_endereco_leitura_51"
        Me.tab_endereco_leitura_51.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_51.TabIndex = 2519
        Me.tab_endereco_leitura_51.Text = "0"
        Me.tab_endereco_leitura_51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_52
        '
        Me.tab_endereco_leitura_52.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_52.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_52.CausesValidation = False
        Me.tab_endereco_leitura_52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_52.Location = New System.Drawing.Point(419, 311)
        Me.tab_endereco_leitura_52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_52.Name = "tab_endereco_leitura_52"
        Me.tab_endereco_leitura_52.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_52.TabIndex = 2519
        Me.tab_endereco_leitura_52.Text = "0"
        Me.tab_endereco_leitura_52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_53
        '
        Me.tab_endereco_leitura_53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_53.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_53.CausesValidation = False
        Me.tab_endereco_leitura_53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_53.Location = New System.Drawing.Point(419, 339)
        Me.tab_endereco_leitura_53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_53.Name = "tab_endereco_leitura_53"
        Me.tab_endereco_leitura_53.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_53.TabIndex = 2519
        Me.tab_endereco_leitura_53.Text = "0"
        Me.tab_endereco_leitura_53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_54
        '
        Me.tab_endereco_leitura_54.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_54.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_54.CausesValidation = False
        Me.tab_endereco_leitura_54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_54.Location = New System.Drawing.Point(419, 367)
        Me.tab_endereco_leitura_54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_54.Name = "tab_endereco_leitura_54"
        Me.tab_endereco_leitura_54.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_54.TabIndex = 2519
        Me.tab_endereco_leitura_54.Text = "0"
        Me.tab_endereco_leitura_54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_55
        '
        Me.tab_endereco_leitura_55.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_55.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_55.CausesValidation = False
        Me.tab_endereco_leitura_55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_55.Location = New System.Drawing.Point(419, 395)
        Me.tab_endereco_leitura_55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_55.Name = "tab_endereco_leitura_55"
        Me.tab_endereco_leitura_55.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_55.TabIndex = 2519
        Me.tab_endereco_leitura_55.Text = "0"
        Me.tab_endereco_leitura_55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_56
        '
        Me.tab_endereco_leitura_56.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_56.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_56.CausesValidation = False
        Me.tab_endereco_leitura_56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_56.Location = New System.Drawing.Point(419, 423)
        Me.tab_endereco_leitura_56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_56.Name = "tab_endereco_leitura_56"
        Me.tab_endereco_leitura_56.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_56.TabIndex = 2519
        Me.tab_endereco_leitura_56.Text = "0"
        Me.tab_endereco_leitura_56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_57
        '
        Me.tab_endereco_leitura_57.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_57.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_57.CausesValidation = False
        Me.tab_endereco_leitura_57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_57.Location = New System.Drawing.Point(419, 451)
        Me.tab_endereco_leitura_57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_57.Name = "tab_endereco_leitura_57"
        Me.tab_endereco_leitura_57.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_57.TabIndex = 2519
        Me.tab_endereco_leitura_57.Text = "0"
        Me.tab_endereco_leitura_57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_58
        '
        Me.tab_endereco_leitura_58.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_58.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_58.CausesValidation = False
        Me.tab_endereco_leitura_58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_58.Location = New System.Drawing.Point(419, 479)
        Me.tab_endereco_leitura_58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_58.Name = "tab_endereco_leitura_58"
        Me.tab_endereco_leitura_58.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_58.TabIndex = 2519
        Me.tab_endereco_leitura_58.Text = "0"
        Me.tab_endereco_leitura_58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_59
        '
        Me.tab_endereco_leitura_59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_59.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_59.CausesValidation = False
        Me.tab_endereco_leitura_59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_59.Location = New System.Drawing.Point(419, 507)
        Me.tab_endereco_leitura_59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_59.Name = "tab_endereco_leitura_59"
        Me.tab_endereco_leitura_59.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_59.TabIndex = 2519
        Me.tab_endereco_leitura_59.Text = "0"
        Me.tab_endereco_leitura_59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_60
        '
        Me.tab_endereco_leitura_60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_60.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_60.CausesValidation = False
        Me.tab_endereco_leitura_60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_60.Location = New System.Drawing.Point(419, 540)
        Me.tab_endereco_leitura_60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_60.Name = "tab_endereco_leitura_60"
        Me.tab_endereco_leitura_60.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_60.TabIndex = 2519
        Me.tab_endereco_leitura_60.Text = "0"
        Me.tab_endereco_leitura_60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_61
        '
        Me.tab_endereco_leitura_61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_61.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_61.CausesValidation = False
        Me.tab_endereco_leitura_61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_61.Location = New System.Drawing.Point(625, 3)
        Me.tab_endereco_leitura_61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_61.Name = "tab_endereco_leitura_61"
        Me.tab_endereco_leitura_61.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_61.TabIndex = 2519
        Me.tab_endereco_leitura_61.Text = "0"
        Me.tab_endereco_leitura_61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_62
        '
        Me.tab_endereco_leitura_62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_62.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_62.CausesValidation = False
        Me.tab_endereco_leitura_62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_62.Location = New System.Drawing.Point(625, 31)
        Me.tab_endereco_leitura_62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_62.Name = "tab_endereco_leitura_62"
        Me.tab_endereco_leitura_62.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_62.TabIndex = 2519
        Me.tab_endereco_leitura_62.Text = "0"
        Me.tab_endereco_leitura_62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_63
        '
        Me.tab_endereco_leitura_63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_63.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_63.CausesValidation = False
        Me.tab_endereco_leitura_63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_63.Location = New System.Drawing.Point(625, 59)
        Me.tab_endereco_leitura_63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_63.Name = "tab_endereco_leitura_63"
        Me.tab_endereco_leitura_63.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_63.TabIndex = 2519
        Me.tab_endereco_leitura_63.Text = "0"
        Me.tab_endereco_leitura_63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_64
        '
        Me.tab_endereco_leitura_64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_64.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_64.CausesValidation = False
        Me.tab_endereco_leitura_64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_64.Location = New System.Drawing.Point(625, 87)
        Me.tab_endereco_leitura_64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_64.Name = "tab_endereco_leitura_64"
        Me.tab_endereco_leitura_64.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_64.TabIndex = 2519
        Me.tab_endereco_leitura_64.Text = "0"
        Me.tab_endereco_leitura_64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_65
        '
        Me.tab_endereco_leitura_65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_65.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_65.CausesValidation = False
        Me.tab_endereco_leitura_65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_65.Location = New System.Drawing.Point(625, 115)
        Me.tab_endereco_leitura_65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_65.Name = "tab_endereco_leitura_65"
        Me.tab_endereco_leitura_65.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_65.TabIndex = 2519
        Me.tab_endereco_leitura_65.Text = "0"
        Me.tab_endereco_leitura_65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_66
        '
        Me.tab_endereco_leitura_66.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_66.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_66.CausesValidation = False
        Me.tab_endereco_leitura_66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_66.Location = New System.Drawing.Point(625, 143)
        Me.tab_endereco_leitura_66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_66.Name = "tab_endereco_leitura_66"
        Me.tab_endereco_leitura_66.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_66.TabIndex = 2519
        Me.tab_endereco_leitura_66.Text = "0"
        Me.tab_endereco_leitura_66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_67
        '
        Me.tab_endereco_leitura_67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_67.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_67.CausesValidation = False
        Me.tab_endereco_leitura_67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_67.Location = New System.Drawing.Point(625, 171)
        Me.tab_endereco_leitura_67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_67.Name = "tab_endereco_leitura_67"
        Me.tab_endereco_leitura_67.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_67.TabIndex = 2519
        Me.tab_endereco_leitura_67.Text = "0"
        Me.tab_endereco_leitura_67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_68
        '
        Me.tab_endereco_leitura_68.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_68.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_68.CausesValidation = False
        Me.tab_endereco_leitura_68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_68.Location = New System.Drawing.Point(625, 199)
        Me.tab_endereco_leitura_68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_68.Name = "tab_endereco_leitura_68"
        Me.tab_endereco_leitura_68.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_68.TabIndex = 2519
        Me.tab_endereco_leitura_68.Text = "0"
        Me.tab_endereco_leitura_68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_69
        '
        Me.tab_endereco_leitura_69.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_69.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_69.CausesValidation = False
        Me.tab_endereco_leitura_69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_69.Location = New System.Drawing.Point(625, 227)
        Me.tab_endereco_leitura_69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_69.Name = "tab_endereco_leitura_69"
        Me.tab_endereco_leitura_69.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_69.TabIndex = 2519
        Me.tab_endereco_leitura_69.Text = "0"
        Me.tab_endereco_leitura_69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_70
        '
        Me.tab_endereco_leitura_70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_70.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_70.CausesValidation = False
        Me.tab_endereco_leitura_70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_70.Location = New System.Drawing.Point(625, 255)
        Me.tab_endereco_leitura_70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_70.Name = "tab_endereco_leitura_70"
        Me.tab_endereco_leitura_70.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_70.TabIndex = 2519
        Me.tab_endereco_leitura_70.Text = "0"
        Me.tab_endereco_leitura_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_71
        '
        Me.tab_endereco_leitura_71.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_71.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_71.CausesValidation = False
        Me.tab_endereco_leitura_71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_71.Location = New System.Drawing.Point(625, 283)
        Me.tab_endereco_leitura_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_71.Name = "tab_endereco_leitura_71"
        Me.tab_endereco_leitura_71.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_71.TabIndex = 2519
        Me.tab_endereco_leitura_71.Text = "0"
        Me.tab_endereco_leitura_71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_72
        '
        Me.tab_endereco_leitura_72.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_72.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_72.CausesValidation = False
        Me.tab_endereco_leitura_72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_72.Location = New System.Drawing.Point(625, 311)
        Me.tab_endereco_leitura_72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_72.Name = "tab_endereco_leitura_72"
        Me.tab_endereco_leitura_72.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_72.TabIndex = 2519
        Me.tab_endereco_leitura_72.Text = "0"
        Me.tab_endereco_leitura_72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_73
        '
        Me.tab_endereco_leitura_73.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_73.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_73.CausesValidation = False
        Me.tab_endereco_leitura_73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_73.Location = New System.Drawing.Point(625, 339)
        Me.tab_endereco_leitura_73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_73.Name = "tab_endereco_leitura_73"
        Me.tab_endereco_leitura_73.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_73.TabIndex = 2519
        Me.tab_endereco_leitura_73.Text = "0"
        Me.tab_endereco_leitura_73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_74
        '
        Me.tab_endereco_leitura_74.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_74.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_74.CausesValidation = False
        Me.tab_endereco_leitura_74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_74.Location = New System.Drawing.Point(625, 367)
        Me.tab_endereco_leitura_74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_74.Name = "tab_endereco_leitura_74"
        Me.tab_endereco_leitura_74.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_74.TabIndex = 2519
        Me.tab_endereco_leitura_74.Text = "0"
        Me.tab_endereco_leitura_74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_75
        '
        Me.tab_endereco_leitura_75.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_75.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_75.CausesValidation = False
        Me.tab_endereco_leitura_75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_75.Location = New System.Drawing.Point(625, 395)
        Me.tab_endereco_leitura_75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_75.Name = "tab_endereco_leitura_75"
        Me.tab_endereco_leitura_75.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_75.TabIndex = 2519
        Me.tab_endereco_leitura_75.Text = "0"
        Me.tab_endereco_leitura_75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_76
        '
        Me.tab_endereco_leitura_76.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_76.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_76.CausesValidation = False
        Me.tab_endereco_leitura_76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_76.Location = New System.Drawing.Point(625, 423)
        Me.tab_endereco_leitura_76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_76.Name = "tab_endereco_leitura_76"
        Me.tab_endereco_leitura_76.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_76.TabIndex = 2519
        Me.tab_endereco_leitura_76.Text = "0"
        Me.tab_endereco_leitura_76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_77
        '
        Me.tab_endereco_leitura_77.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_77.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_77.CausesValidation = False
        Me.tab_endereco_leitura_77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_77.Location = New System.Drawing.Point(625, 451)
        Me.tab_endereco_leitura_77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_77.Name = "tab_endereco_leitura_77"
        Me.tab_endereco_leitura_77.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_77.TabIndex = 2519
        Me.tab_endereco_leitura_77.Text = "0"
        Me.tab_endereco_leitura_77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_78
        '
        Me.tab_endereco_leitura_78.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_78.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_78.CausesValidation = False
        Me.tab_endereco_leitura_78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_78.Location = New System.Drawing.Point(625, 479)
        Me.tab_endereco_leitura_78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_78.Name = "tab_endereco_leitura_78"
        Me.tab_endereco_leitura_78.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_78.TabIndex = 2519
        Me.tab_endereco_leitura_78.Text = "0"
        Me.tab_endereco_leitura_78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_79
        '
        Me.tab_endereco_leitura_79.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_79.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_79.CausesValidation = False
        Me.tab_endereco_leitura_79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_79.Location = New System.Drawing.Point(625, 507)
        Me.tab_endereco_leitura_79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_79.Name = "tab_endereco_leitura_79"
        Me.tab_endereco_leitura_79.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_79.TabIndex = 2519
        Me.tab_endereco_leitura_79.Text = "0"
        Me.tab_endereco_leitura_79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_80
        '
        Me.tab_endereco_leitura_80.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_80.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_80.CausesValidation = False
        Me.tab_endereco_leitura_80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_80.Location = New System.Drawing.Point(625, 540)
        Me.tab_endereco_leitura_80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_80.Name = "tab_endereco_leitura_80"
        Me.tab_endereco_leitura_80.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_80.TabIndex = 2519
        Me.tab_endereco_leitura_80.Text = "0"
        Me.tab_endereco_leitura_80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_81
        '
        Me.tab_endereco_leitura_81.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_81.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_81.CausesValidation = False
        Me.tab_endereco_leitura_81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_81.Location = New System.Drawing.Point(831, 3)
        Me.tab_endereco_leitura_81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_81.Name = "tab_endereco_leitura_81"
        Me.tab_endereco_leitura_81.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_81.TabIndex = 2519
        Me.tab_endereco_leitura_81.Text = "0"
        Me.tab_endereco_leitura_81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_82
        '
        Me.tab_endereco_leitura_82.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_82.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_82.CausesValidation = False
        Me.tab_endereco_leitura_82.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_82.Location = New System.Drawing.Point(831, 31)
        Me.tab_endereco_leitura_82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_82.Name = "tab_endereco_leitura_82"
        Me.tab_endereco_leitura_82.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_82.TabIndex = 2519
        Me.tab_endereco_leitura_82.Text = "0"
        Me.tab_endereco_leitura_82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_83
        '
        Me.tab_endereco_leitura_83.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_83.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_83.CausesValidation = False
        Me.tab_endereco_leitura_83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_83.Location = New System.Drawing.Point(831, 59)
        Me.tab_endereco_leitura_83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_83.Name = "tab_endereco_leitura_83"
        Me.tab_endereco_leitura_83.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_83.TabIndex = 2519
        Me.tab_endereco_leitura_83.Text = "0"
        Me.tab_endereco_leitura_83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_84
        '
        Me.tab_endereco_leitura_84.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_84.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_84.CausesValidation = False
        Me.tab_endereco_leitura_84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_84.Location = New System.Drawing.Point(831, 87)
        Me.tab_endereco_leitura_84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_84.Name = "tab_endereco_leitura_84"
        Me.tab_endereco_leitura_84.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_84.TabIndex = 2519
        Me.tab_endereco_leitura_84.Text = "0"
        Me.tab_endereco_leitura_84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_85
        '
        Me.tab_endereco_leitura_85.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_85.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_85.CausesValidation = False
        Me.tab_endereco_leitura_85.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_85.Location = New System.Drawing.Point(831, 115)
        Me.tab_endereco_leitura_85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_85.Name = "tab_endereco_leitura_85"
        Me.tab_endereco_leitura_85.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_85.TabIndex = 2519
        Me.tab_endereco_leitura_85.Text = "0"
        Me.tab_endereco_leitura_85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_86
        '
        Me.tab_endereco_leitura_86.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_86.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_86.CausesValidation = False
        Me.tab_endereco_leitura_86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_86.Location = New System.Drawing.Point(831, 143)
        Me.tab_endereco_leitura_86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_86.Name = "tab_endereco_leitura_86"
        Me.tab_endereco_leitura_86.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_86.TabIndex = 2519
        Me.tab_endereco_leitura_86.Text = "0"
        Me.tab_endereco_leitura_86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_87
        '
        Me.tab_endereco_leitura_87.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_87.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_87.CausesValidation = False
        Me.tab_endereco_leitura_87.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_87.Location = New System.Drawing.Point(831, 171)
        Me.tab_endereco_leitura_87.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_87.Name = "tab_endereco_leitura_87"
        Me.tab_endereco_leitura_87.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_87.TabIndex = 2519
        Me.tab_endereco_leitura_87.Text = "0"
        Me.tab_endereco_leitura_87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_88
        '
        Me.tab_endereco_leitura_88.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_88.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_88.CausesValidation = False
        Me.tab_endereco_leitura_88.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_88.Location = New System.Drawing.Point(831, 199)
        Me.tab_endereco_leitura_88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_88.Name = "tab_endereco_leitura_88"
        Me.tab_endereco_leitura_88.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_88.TabIndex = 2519
        Me.tab_endereco_leitura_88.Text = "0"
        Me.tab_endereco_leitura_88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_89
        '
        Me.tab_endereco_leitura_89.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_89.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_89.CausesValidation = False
        Me.tab_endereco_leitura_89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_89.Location = New System.Drawing.Point(831, 227)
        Me.tab_endereco_leitura_89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_89.Name = "tab_endereco_leitura_89"
        Me.tab_endereco_leitura_89.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_89.TabIndex = 2519
        Me.tab_endereco_leitura_89.Text = "0"
        Me.tab_endereco_leitura_89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_90
        '
        Me.tab_endereco_leitura_90.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_90.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_90.CausesValidation = False
        Me.tab_endereco_leitura_90.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_90.Location = New System.Drawing.Point(831, 255)
        Me.tab_endereco_leitura_90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_90.Name = "tab_endereco_leitura_90"
        Me.tab_endereco_leitura_90.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_90.TabIndex = 2519
        Me.tab_endereco_leitura_90.Text = "0"
        Me.tab_endereco_leitura_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_91
        '
        Me.tab_endereco_leitura_91.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_91.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_91.CausesValidation = False
        Me.tab_endereco_leitura_91.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_91.Location = New System.Drawing.Point(831, 283)
        Me.tab_endereco_leitura_91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_91.Name = "tab_endereco_leitura_91"
        Me.tab_endereco_leitura_91.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_91.TabIndex = 2519
        Me.tab_endereco_leitura_91.Text = "0"
        Me.tab_endereco_leitura_91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_92
        '
        Me.tab_endereco_leitura_92.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_92.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_92.CausesValidation = False
        Me.tab_endereco_leitura_92.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_92.Location = New System.Drawing.Point(831, 311)
        Me.tab_endereco_leitura_92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_92.Name = "tab_endereco_leitura_92"
        Me.tab_endereco_leitura_92.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_92.TabIndex = 2519
        Me.tab_endereco_leitura_92.Text = "0"
        Me.tab_endereco_leitura_92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_93
        '
        Me.tab_endereco_leitura_93.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_93.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_93.CausesValidation = False
        Me.tab_endereco_leitura_93.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_93.Location = New System.Drawing.Point(831, 339)
        Me.tab_endereco_leitura_93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_93.Name = "tab_endereco_leitura_93"
        Me.tab_endereco_leitura_93.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_93.TabIndex = 2519
        Me.tab_endereco_leitura_93.Text = "0"
        Me.tab_endereco_leitura_93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_94
        '
        Me.tab_endereco_leitura_94.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_94.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_94.CausesValidation = False
        Me.tab_endereco_leitura_94.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_94.Location = New System.Drawing.Point(831, 367)
        Me.tab_endereco_leitura_94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_94.Name = "tab_endereco_leitura_94"
        Me.tab_endereco_leitura_94.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_94.TabIndex = 2519
        Me.tab_endereco_leitura_94.Text = "0"
        Me.tab_endereco_leitura_94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_95
        '
        Me.tab_endereco_leitura_95.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_95.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_95.CausesValidation = False
        Me.tab_endereco_leitura_95.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_95.Location = New System.Drawing.Point(831, 395)
        Me.tab_endereco_leitura_95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_95.Name = "tab_endereco_leitura_95"
        Me.tab_endereco_leitura_95.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_95.TabIndex = 2519
        Me.tab_endereco_leitura_95.Text = "0"
        Me.tab_endereco_leitura_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_96
        '
        Me.tab_endereco_leitura_96.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_96.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_96.CausesValidation = False
        Me.tab_endereco_leitura_96.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_96.Location = New System.Drawing.Point(831, 423)
        Me.tab_endereco_leitura_96.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_96.Name = "tab_endereco_leitura_96"
        Me.tab_endereco_leitura_96.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_96.TabIndex = 2519
        Me.tab_endereco_leitura_96.Text = "0"
        Me.tab_endereco_leitura_96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_97
        '
        Me.tab_endereco_leitura_97.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_97.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_97.CausesValidation = False
        Me.tab_endereco_leitura_97.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_97.Location = New System.Drawing.Point(831, 451)
        Me.tab_endereco_leitura_97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_97.Name = "tab_endereco_leitura_97"
        Me.tab_endereco_leitura_97.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_97.TabIndex = 2519
        Me.tab_endereco_leitura_97.Text = "0"
        Me.tab_endereco_leitura_97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_98
        '
        Me.tab_endereco_leitura_98.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_98.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_98.CausesValidation = False
        Me.tab_endereco_leitura_98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_98.Location = New System.Drawing.Point(831, 479)
        Me.tab_endereco_leitura_98.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_98.Name = "tab_endereco_leitura_98"
        Me.tab_endereco_leitura_98.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_98.TabIndex = 2519
        Me.tab_endereco_leitura_98.Text = "0"
        Me.tab_endereco_leitura_98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_99
        '
        Me.tab_endereco_leitura_99.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_99.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_99.CausesValidation = False
        Me.tab_endereco_leitura_99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_99.Location = New System.Drawing.Point(831, 507)
        Me.tab_endereco_leitura_99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_99.Name = "tab_endereco_leitura_99"
        Me.tab_endereco_leitura_99.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_99.TabIndex = 2519
        Me.tab_endereco_leitura_99.Text = "0"
        Me.tab_endereco_leitura_99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_leitura_100
        '
        Me.tab_endereco_leitura_100.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_leitura_100.BackColor = System.Drawing.Color.White
        Me.tab_endereco_leitura_100.CausesValidation = False
        Me.tab_endereco_leitura_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_leitura_100.Location = New System.Drawing.Point(831, 540)
        Me.tab_endereco_leitura_100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_leitura_100.Name = "tab_endereco_leitura_100"
        Me.tab_endereco_leitura_100.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_leitura_100.TabIndex = 2519
        Me.tab_endereco_leitura_100.Text = "0"
        Me.tab_endereco_leitura_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_1
        '
        Me.tab_valor_leitura_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_1.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_1.CausesValidation = False
        Me.tab_valor_leitura_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_1.Location = New System.Drawing.Point(77, 3)
        Me.tab_valor_leitura_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_1.Name = "tab_valor_leitura_1"
        Me.tab_valor_leitura_1.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_1.TabIndex = 2519
        Me.tab_valor_leitura_1.Text = "0"
        Me.tab_valor_leitura_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_2
        '
        Me.tab_valor_leitura_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_2.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_2.CausesValidation = False
        Me.tab_valor_leitura_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_2.Location = New System.Drawing.Point(77, 31)
        Me.tab_valor_leitura_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_2.Name = "tab_valor_leitura_2"
        Me.tab_valor_leitura_2.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_2.TabIndex = 2519
        Me.tab_valor_leitura_2.Text = "0"
        Me.tab_valor_leitura_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_3
        '
        Me.tab_valor_leitura_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_3.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_3.CausesValidation = False
        Me.tab_valor_leitura_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_3.Location = New System.Drawing.Point(77, 59)
        Me.tab_valor_leitura_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_3.Name = "tab_valor_leitura_3"
        Me.tab_valor_leitura_3.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_3.TabIndex = 2519
        Me.tab_valor_leitura_3.Text = "0"
        Me.tab_valor_leitura_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_4
        '
        Me.tab_valor_leitura_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_4.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_4.CausesValidation = False
        Me.tab_valor_leitura_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_4.Location = New System.Drawing.Point(77, 87)
        Me.tab_valor_leitura_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_4.Name = "tab_valor_leitura_4"
        Me.tab_valor_leitura_4.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_4.TabIndex = 2519
        Me.tab_valor_leitura_4.Text = "0"
        Me.tab_valor_leitura_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_5
        '
        Me.tab_valor_leitura_5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_5.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_5.CausesValidation = False
        Me.tab_valor_leitura_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_5.Location = New System.Drawing.Point(77, 115)
        Me.tab_valor_leitura_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_5.Name = "tab_valor_leitura_5"
        Me.tab_valor_leitura_5.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_5.TabIndex = 2519
        Me.tab_valor_leitura_5.Text = "0"
        Me.tab_valor_leitura_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_6
        '
        Me.tab_valor_leitura_6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_6.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_6.CausesValidation = False
        Me.tab_valor_leitura_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_6.Location = New System.Drawing.Point(77, 143)
        Me.tab_valor_leitura_6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_6.Name = "tab_valor_leitura_6"
        Me.tab_valor_leitura_6.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_6.TabIndex = 2519
        Me.tab_valor_leitura_6.Text = "0"
        Me.tab_valor_leitura_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_7
        '
        Me.tab_valor_leitura_7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_7.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_7.CausesValidation = False
        Me.tab_valor_leitura_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_7.Location = New System.Drawing.Point(77, 171)
        Me.tab_valor_leitura_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_7.Name = "tab_valor_leitura_7"
        Me.tab_valor_leitura_7.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_7.TabIndex = 2519
        Me.tab_valor_leitura_7.Text = "0"
        Me.tab_valor_leitura_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_8
        '
        Me.tab_valor_leitura_8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_8.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_8.CausesValidation = False
        Me.tab_valor_leitura_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_8.Location = New System.Drawing.Point(77, 199)
        Me.tab_valor_leitura_8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_8.Name = "tab_valor_leitura_8"
        Me.tab_valor_leitura_8.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_8.TabIndex = 2519
        Me.tab_valor_leitura_8.Text = "0"
        Me.tab_valor_leitura_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_9
        '
        Me.tab_valor_leitura_9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_9.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_9.CausesValidation = False
        Me.tab_valor_leitura_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_9.Location = New System.Drawing.Point(77, 227)
        Me.tab_valor_leitura_9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_9.Name = "tab_valor_leitura_9"
        Me.tab_valor_leitura_9.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_9.TabIndex = 2519
        Me.tab_valor_leitura_9.Text = "0"
        Me.tab_valor_leitura_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_10
        '
        Me.tab_valor_leitura_10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_10.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_10.CausesValidation = False
        Me.tab_valor_leitura_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_10.Location = New System.Drawing.Point(77, 255)
        Me.tab_valor_leitura_10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_10.Name = "tab_valor_leitura_10"
        Me.tab_valor_leitura_10.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_10.TabIndex = 2519
        Me.tab_valor_leitura_10.Text = "0"
        Me.tab_valor_leitura_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_11
        '
        Me.tab_valor_leitura_11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_11.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_11.CausesValidation = False
        Me.tab_valor_leitura_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_11.Location = New System.Drawing.Point(77, 283)
        Me.tab_valor_leitura_11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_11.Name = "tab_valor_leitura_11"
        Me.tab_valor_leitura_11.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_11.TabIndex = 2519
        Me.tab_valor_leitura_11.Text = "0"
        Me.tab_valor_leitura_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_12
        '
        Me.tab_valor_leitura_12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_12.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_12.CausesValidation = False
        Me.tab_valor_leitura_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_12.Location = New System.Drawing.Point(77, 311)
        Me.tab_valor_leitura_12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_12.Name = "tab_valor_leitura_12"
        Me.tab_valor_leitura_12.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_12.TabIndex = 2519
        Me.tab_valor_leitura_12.Text = "0"
        Me.tab_valor_leitura_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_13
        '
        Me.tab_valor_leitura_13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_13.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_13.CausesValidation = False
        Me.tab_valor_leitura_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_13.Location = New System.Drawing.Point(77, 339)
        Me.tab_valor_leitura_13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_13.Name = "tab_valor_leitura_13"
        Me.tab_valor_leitura_13.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_13.TabIndex = 2519
        Me.tab_valor_leitura_13.Text = "0"
        Me.tab_valor_leitura_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_14
        '
        Me.tab_valor_leitura_14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_14.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_14.CausesValidation = False
        Me.tab_valor_leitura_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_14.Location = New System.Drawing.Point(77, 367)
        Me.tab_valor_leitura_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_14.Name = "tab_valor_leitura_14"
        Me.tab_valor_leitura_14.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_14.TabIndex = 2519
        Me.tab_valor_leitura_14.Text = "0"
        Me.tab_valor_leitura_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_15
        '
        Me.tab_valor_leitura_15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_15.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_15.CausesValidation = False
        Me.tab_valor_leitura_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_15.Location = New System.Drawing.Point(77, 395)
        Me.tab_valor_leitura_15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_15.Name = "tab_valor_leitura_15"
        Me.tab_valor_leitura_15.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_15.TabIndex = 2519
        Me.tab_valor_leitura_15.Text = "0"
        Me.tab_valor_leitura_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_16
        '
        Me.tab_valor_leitura_16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_16.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_16.CausesValidation = False
        Me.tab_valor_leitura_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_16.Location = New System.Drawing.Point(77, 423)
        Me.tab_valor_leitura_16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_16.Name = "tab_valor_leitura_16"
        Me.tab_valor_leitura_16.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_16.TabIndex = 2519
        Me.tab_valor_leitura_16.Text = "0"
        Me.tab_valor_leitura_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_17
        '
        Me.tab_valor_leitura_17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_17.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_17.CausesValidation = False
        Me.tab_valor_leitura_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_17.Location = New System.Drawing.Point(77, 451)
        Me.tab_valor_leitura_17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_17.Name = "tab_valor_leitura_17"
        Me.tab_valor_leitura_17.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_17.TabIndex = 2519
        Me.tab_valor_leitura_17.Text = "0"
        Me.tab_valor_leitura_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_18
        '
        Me.tab_valor_leitura_18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_18.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_18.CausesValidation = False
        Me.tab_valor_leitura_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_18.Location = New System.Drawing.Point(77, 479)
        Me.tab_valor_leitura_18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_18.Name = "tab_valor_leitura_18"
        Me.tab_valor_leitura_18.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_18.TabIndex = 2519
        Me.tab_valor_leitura_18.Text = "0"
        Me.tab_valor_leitura_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_19
        '
        Me.tab_valor_leitura_19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_19.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_19.CausesValidation = False
        Me.tab_valor_leitura_19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_19.Location = New System.Drawing.Point(77, 507)
        Me.tab_valor_leitura_19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_19.Name = "tab_valor_leitura_19"
        Me.tab_valor_leitura_19.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_19.TabIndex = 2519
        Me.tab_valor_leitura_19.Text = "0"
        Me.tab_valor_leitura_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_20
        '
        Me.tab_valor_leitura_20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_20.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_20.CausesValidation = False
        Me.tab_valor_leitura_20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_20.Location = New System.Drawing.Point(77, 540)
        Me.tab_valor_leitura_20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_20.Name = "tab_valor_leitura_20"
        Me.tab_valor_leitura_20.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_20.TabIndex = 2519
        Me.tab_valor_leitura_20.Text = "0"
        Me.tab_valor_leitura_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_21
        '
        Me.tab_valor_leitura_21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_21.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_21.CausesValidation = False
        Me.tab_valor_leitura_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_21.Location = New System.Drawing.Point(283, 3)
        Me.tab_valor_leitura_21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_21.Name = "tab_valor_leitura_21"
        Me.tab_valor_leitura_21.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_21.TabIndex = 2519
        Me.tab_valor_leitura_21.Text = "0"
        Me.tab_valor_leitura_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_22
        '
        Me.tab_valor_leitura_22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_22.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_22.CausesValidation = False
        Me.tab_valor_leitura_22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_22.Location = New System.Drawing.Point(283, 31)
        Me.tab_valor_leitura_22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_22.Name = "tab_valor_leitura_22"
        Me.tab_valor_leitura_22.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_22.TabIndex = 2519
        Me.tab_valor_leitura_22.Text = "0"
        Me.tab_valor_leitura_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_23
        '
        Me.tab_valor_leitura_23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_23.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_23.CausesValidation = False
        Me.tab_valor_leitura_23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_23.Location = New System.Drawing.Point(283, 59)
        Me.tab_valor_leitura_23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_23.Name = "tab_valor_leitura_23"
        Me.tab_valor_leitura_23.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_23.TabIndex = 2519
        Me.tab_valor_leitura_23.Text = "0"
        Me.tab_valor_leitura_23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_24
        '
        Me.tab_valor_leitura_24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_24.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_24.CausesValidation = False
        Me.tab_valor_leitura_24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_24.Location = New System.Drawing.Point(283, 87)
        Me.tab_valor_leitura_24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_24.Name = "tab_valor_leitura_24"
        Me.tab_valor_leitura_24.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_24.TabIndex = 2519
        Me.tab_valor_leitura_24.Text = "0"
        Me.tab_valor_leitura_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_25
        '
        Me.tab_valor_leitura_25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_25.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_25.CausesValidation = False
        Me.tab_valor_leitura_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_25.Location = New System.Drawing.Point(283, 115)
        Me.tab_valor_leitura_25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_25.Name = "tab_valor_leitura_25"
        Me.tab_valor_leitura_25.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_25.TabIndex = 2519
        Me.tab_valor_leitura_25.Text = "0"
        Me.tab_valor_leitura_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_26
        '
        Me.tab_valor_leitura_26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_26.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_26.CausesValidation = False
        Me.tab_valor_leitura_26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_26.Location = New System.Drawing.Point(283, 143)
        Me.tab_valor_leitura_26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_26.Name = "tab_valor_leitura_26"
        Me.tab_valor_leitura_26.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_26.TabIndex = 2519
        Me.tab_valor_leitura_26.Text = "0"
        Me.tab_valor_leitura_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_27
        '
        Me.tab_valor_leitura_27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_27.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_27.CausesValidation = False
        Me.tab_valor_leitura_27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_27.Location = New System.Drawing.Point(283, 171)
        Me.tab_valor_leitura_27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_27.Name = "tab_valor_leitura_27"
        Me.tab_valor_leitura_27.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_27.TabIndex = 2519
        Me.tab_valor_leitura_27.Text = "0"
        Me.tab_valor_leitura_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_28
        '
        Me.tab_valor_leitura_28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_28.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_28.CausesValidation = False
        Me.tab_valor_leitura_28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_28.Location = New System.Drawing.Point(283, 199)
        Me.tab_valor_leitura_28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_28.Name = "tab_valor_leitura_28"
        Me.tab_valor_leitura_28.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_28.TabIndex = 2519
        Me.tab_valor_leitura_28.Text = "0"
        Me.tab_valor_leitura_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_29
        '
        Me.tab_valor_leitura_29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_29.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_29.CausesValidation = False
        Me.tab_valor_leitura_29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_29.Location = New System.Drawing.Point(283, 227)
        Me.tab_valor_leitura_29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_29.Name = "tab_valor_leitura_29"
        Me.tab_valor_leitura_29.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_29.TabIndex = 2519
        Me.tab_valor_leitura_29.Text = "0"
        Me.tab_valor_leitura_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_30
        '
        Me.tab_valor_leitura_30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_30.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_30.CausesValidation = False
        Me.tab_valor_leitura_30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_30.Location = New System.Drawing.Point(283, 255)
        Me.tab_valor_leitura_30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_30.Name = "tab_valor_leitura_30"
        Me.tab_valor_leitura_30.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_30.TabIndex = 2519
        Me.tab_valor_leitura_30.Text = "0"
        Me.tab_valor_leitura_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_31
        '
        Me.tab_valor_leitura_31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_31.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_31.CausesValidation = False
        Me.tab_valor_leitura_31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_31.Location = New System.Drawing.Point(283, 283)
        Me.tab_valor_leitura_31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_31.Name = "tab_valor_leitura_31"
        Me.tab_valor_leitura_31.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_31.TabIndex = 2519
        Me.tab_valor_leitura_31.Text = "0"
        Me.tab_valor_leitura_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_32
        '
        Me.tab_valor_leitura_32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_32.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_32.CausesValidation = False
        Me.tab_valor_leitura_32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_32.Location = New System.Drawing.Point(283, 311)
        Me.tab_valor_leitura_32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_32.Name = "tab_valor_leitura_32"
        Me.tab_valor_leitura_32.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_32.TabIndex = 2519
        Me.tab_valor_leitura_32.Text = "0"
        Me.tab_valor_leitura_32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_33
        '
        Me.tab_valor_leitura_33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_33.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_33.CausesValidation = False
        Me.tab_valor_leitura_33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_33.Location = New System.Drawing.Point(283, 339)
        Me.tab_valor_leitura_33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_33.Name = "tab_valor_leitura_33"
        Me.tab_valor_leitura_33.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_33.TabIndex = 2519
        Me.tab_valor_leitura_33.Text = "0"
        Me.tab_valor_leitura_33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_34
        '
        Me.tab_valor_leitura_34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_34.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_34.CausesValidation = False
        Me.tab_valor_leitura_34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_34.Location = New System.Drawing.Point(283, 367)
        Me.tab_valor_leitura_34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_34.Name = "tab_valor_leitura_34"
        Me.tab_valor_leitura_34.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_34.TabIndex = 2519
        Me.tab_valor_leitura_34.Text = "0"
        Me.tab_valor_leitura_34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_35
        '
        Me.tab_valor_leitura_35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_35.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_35.CausesValidation = False
        Me.tab_valor_leitura_35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_35.Location = New System.Drawing.Point(283, 395)
        Me.tab_valor_leitura_35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_35.Name = "tab_valor_leitura_35"
        Me.tab_valor_leitura_35.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_35.TabIndex = 2519
        Me.tab_valor_leitura_35.Text = "0"
        Me.tab_valor_leitura_35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_36
        '
        Me.tab_valor_leitura_36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_36.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_36.CausesValidation = False
        Me.tab_valor_leitura_36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_36.Location = New System.Drawing.Point(283, 423)
        Me.tab_valor_leitura_36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_36.Name = "tab_valor_leitura_36"
        Me.tab_valor_leitura_36.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_36.TabIndex = 2519
        Me.tab_valor_leitura_36.Text = "0"
        Me.tab_valor_leitura_36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_37
        '
        Me.tab_valor_leitura_37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_37.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_37.CausesValidation = False
        Me.tab_valor_leitura_37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_37.Location = New System.Drawing.Point(283, 451)
        Me.tab_valor_leitura_37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_37.Name = "tab_valor_leitura_37"
        Me.tab_valor_leitura_37.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_37.TabIndex = 2519
        Me.tab_valor_leitura_37.Text = "0"
        Me.tab_valor_leitura_37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_38
        '
        Me.tab_valor_leitura_38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_38.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_38.CausesValidation = False
        Me.tab_valor_leitura_38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_38.Location = New System.Drawing.Point(283, 479)
        Me.tab_valor_leitura_38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_38.Name = "tab_valor_leitura_38"
        Me.tab_valor_leitura_38.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_38.TabIndex = 2519
        Me.tab_valor_leitura_38.Text = "0"
        Me.tab_valor_leitura_38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_39
        '
        Me.tab_valor_leitura_39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_39.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_39.CausesValidation = False
        Me.tab_valor_leitura_39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_39.Location = New System.Drawing.Point(283, 507)
        Me.tab_valor_leitura_39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_39.Name = "tab_valor_leitura_39"
        Me.tab_valor_leitura_39.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_39.TabIndex = 2519
        Me.tab_valor_leitura_39.Text = "0"
        Me.tab_valor_leitura_39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_40
        '
        Me.tab_valor_leitura_40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_40.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_40.CausesValidation = False
        Me.tab_valor_leitura_40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_40.Location = New System.Drawing.Point(283, 540)
        Me.tab_valor_leitura_40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_40.Name = "tab_valor_leitura_40"
        Me.tab_valor_leitura_40.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_40.TabIndex = 2519
        Me.tab_valor_leitura_40.Text = "0"
        Me.tab_valor_leitura_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_41
        '
        Me.tab_valor_leitura_41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_41.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_41.CausesValidation = False
        Me.tab_valor_leitura_41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_41.Location = New System.Drawing.Point(489, 3)
        Me.tab_valor_leitura_41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_41.Name = "tab_valor_leitura_41"
        Me.tab_valor_leitura_41.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_41.TabIndex = 2519
        Me.tab_valor_leitura_41.Text = "0"
        Me.tab_valor_leitura_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_42
        '
        Me.tab_valor_leitura_42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_42.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_42.CausesValidation = False
        Me.tab_valor_leitura_42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_42.Location = New System.Drawing.Point(489, 31)
        Me.tab_valor_leitura_42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_42.Name = "tab_valor_leitura_42"
        Me.tab_valor_leitura_42.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_42.TabIndex = 2519
        Me.tab_valor_leitura_42.Text = "0"
        Me.tab_valor_leitura_42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_43
        '
        Me.tab_valor_leitura_43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_43.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_43.CausesValidation = False
        Me.tab_valor_leitura_43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_43.Location = New System.Drawing.Point(489, 59)
        Me.tab_valor_leitura_43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_43.Name = "tab_valor_leitura_43"
        Me.tab_valor_leitura_43.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_43.TabIndex = 2519
        Me.tab_valor_leitura_43.Text = "0"
        Me.tab_valor_leitura_43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_44
        '
        Me.tab_valor_leitura_44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_44.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_44.CausesValidation = False
        Me.tab_valor_leitura_44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_44.Location = New System.Drawing.Point(489, 87)
        Me.tab_valor_leitura_44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_44.Name = "tab_valor_leitura_44"
        Me.tab_valor_leitura_44.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_44.TabIndex = 2519
        Me.tab_valor_leitura_44.Text = "0"
        Me.tab_valor_leitura_44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_45
        '
        Me.tab_valor_leitura_45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_45.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_45.CausesValidation = False
        Me.tab_valor_leitura_45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_45.Location = New System.Drawing.Point(489, 115)
        Me.tab_valor_leitura_45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_45.Name = "tab_valor_leitura_45"
        Me.tab_valor_leitura_45.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_45.TabIndex = 2519
        Me.tab_valor_leitura_45.Text = "0"
        Me.tab_valor_leitura_45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_46
        '
        Me.tab_valor_leitura_46.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_46.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_46.CausesValidation = False
        Me.tab_valor_leitura_46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_46.Location = New System.Drawing.Point(489, 143)
        Me.tab_valor_leitura_46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_46.Name = "tab_valor_leitura_46"
        Me.tab_valor_leitura_46.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_46.TabIndex = 2519
        Me.tab_valor_leitura_46.Text = "0"
        Me.tab_valor_leitura_46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_47
        '
        Me.tab_valor_leitura_47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_47.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_47.CausesValidation = False
        Me.tab_valor_leitura_47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_47.Location = New System.Drawing.Point(489, 171)
        Me.tab_valor_leitura_47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_47.Name = "tab_valor_leitura_47"
        Me.tab_valor_leitura_47.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_47.TabIndex = 2519
        Me.tab_valor_leitura_47.Text = "0"
        Me.tab_valor_leitura_47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_48
        '
        Me.tab_valor_leitura_48.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_48.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_48.CausesValidation = False
        Me.tab_valor_leitura_48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_48.Location = New System.Drawing.Point(489, 199)
        Me.tab_valor_leitura_48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_48.Name = "tab_valor_leitura_48"
        Me.tab_valor_leitura_48.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_48.TabIndex = 2519
        Me.tab_valor_leitura_48.Text = "0"
        Me.tab_valor_leitura_48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_49
        '
        Me.tab_valor_leitura_49.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_49.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_49.CausesValidation = False
        Me.tab_valor_leitura_49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_49.Location = New System.Drawing.Point(489, 227)
        Me.tab_valor_leitura_49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_49.Name = "tab_valor_leitura_49"
        Me.tab_valor_leitura_49.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_49.TabIndex = 2519
        Me.tab_valor_leitura_49.Text = "0"
        Me.tab_valor_leitura_49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_50
        '
        Me.tab_valor_leitura_50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_50.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_50.CausesValidation = False
        Me.tab_valor_leitura_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_50.Location = New System.Drawing.Point(489, 255)
        Me.tab_valor_leitura_50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_50.Name = "tab_valor_leitura_50"
        Me.tab_valor_leitura_50.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_50.TabIndex = 2519
        Me.tab_valor_leitura_50.Text = "0"
        Me.tab_valor_leitura_50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_51
        '
        Me.tab_valor_leitura_51.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_51.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_51.CausesValidation = False
        Me.tab_valor_leitura_51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_51.Location = New System.Drawing.Point(489, 283)
        Me.tab_valor_leitura_51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_51.Name = "tab_valor_leitura_51"
        Me.tab_valor_leitura_51.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_51.TabIndex = 2519
        Me.tab_valor_leitura_51.Text = "0"
        Me.tab_valor_leitura_51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_52
        '
        Me.tab_valor_leitura_52.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_52.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_52.CausesValidation = False
        Me.tab_valor_leitura_52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_52.Location = New System.Drawing.Point(489, 311)
        Me.tab_valor_leitura_52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_52.Name = "tab_valor_leitura_52"
        Me.tab_valor_leitura_52.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_52.TabIndex = 2519
        Me.tab_valor_leitura_52.Text = "0"
        Me.tab_valor_leitura_52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_53
        '
        Me.tab_valor_leitura_53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_53.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_53.CausesValidation = False
        Me.tab_valor_leitura_53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_53.Location = New System.Drawing.Point(489, 339)
        Me.tab_valor_leitura_53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_53.Name = "tab_valor_leitura_53"
        Me.tab_valor_leitura_53.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_53.TabIndex = 2519
        Me.tab_valor_leitura_53.Text = "0"
        Me.tab_valor_leitura_53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_54
        '
        Me.tab_valor_leitura_54.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_54.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_54.CausesValidation = False
        Me.tab_valor_leitura_54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_54.Location = New System.Drawing.Point(489, 367)
        Me.tab_valor_leitura_54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_54.Name = "tab_valor_leitura_54"
        Me.tab_valor_leitura_54.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_54.TabIndex = 2519
        Me.tab_valor_leitura_54.Text = "0"
        Me.tab_valor_leitura_54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_55
        '
        Me.tab_valor_leitura_55.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_55.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_55.CausesValidation = False
        Me.tab_valor_leitura_55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_55.Location = New System.Drawing.Point(489, 395)
        Me.tab_valor_leitura_55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_55.Name = "tab_valor_leitura_55"
        Me.tab_valor_leitura_55.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_55.TabIndex = 2519
        Me.tab_valor_leitura_55.Text = "0"
        Me.tab_valor_leitura_55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_56
        '
        Me.tab_valor_leitura_56.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_56.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_56.CausesValidation = False
        Me.tab_valor_leitura_56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_56.Location = New System.Drawing.Point(489, 423)
        Me.tab_valor_leitura_56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_56.Name = "tab_valor_leitura_56"
        Me.tab_valor_leitura_56.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_56.TabIndex = 2519
        Me.tab_valor_leitura_56.Text = "0"
        Me.tab_valor_leitura_56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_57
        '
        Me.tab_valor_leitura_57.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_57.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_57.CausesValidation = False
        Me.tab_valor_leitura_57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_57.Location = New System.Drawing.Point(489, 451)
        Me.tab_valor_leitura_57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_57.Name = "tab_valor_leitura_57"
        Me.tab_valor_leitura_57.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_57.TabIndex = 2519
        Me.tab_valor_leitura_57.Text = "0"
        Me.tab_valor_leitura_57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_58
        '
        Me.tab_valor_leitura_58.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_58.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_58.CausesValidation = False
        Me.tab_valor_leitura_58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_58.Location = New System.Drawing.Point(489, 479)
        Me.tab_valor_leitura_58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_58.Name = "tab_valor_leitura_58"
        Me.tab_valor_leitura_58.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_58.TabIndex = 2519
        Me.tab_valor_leitura_58.Text = "0"
        Me.tab_valor_leitura_58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_59
        '
        Me.tab_valor_leitura_59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_59.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_59.CausesValidation = False
        Me.tab_valor_leitura_59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_59.Location = New System.Drawing.Point(489, 507)
        Me.tab_valor_leitura_59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_59.Name = "tab_valor_leitura_59"
        Me.tab_valor_leitura_59.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_59.TabIndex = 2519
        Me.tab_valor_leitura_59.Text = "0"
        Me.tab_valor_leitura_59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_60
        '
        Me.tab_valor_leitura_60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_60.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_60.CausesValidation = False
        Me.tab_valor_leitura_60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_60.Location = New System.Drawing.Point(489, 540)
        Me.tab_valor_leitura_60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_60.Name = "tab_valor_leitura_60"
        Me.tab_valor_leitura_60.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_60.TabIndex = 2519
        Me.tab_valor_leitura_60.Text = "0"
        Me.tab_valor_leitura_60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_61
        '
        Me.tab_valor_leitura_61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_61.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_61.CausesValidation = False
        Me.tab_valor_leitura_61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_61.Location = New System.Drawing.Point(695, 3)
        Me.tab_valor_leitura_61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_61.Name = "tab_valor_leitura_61"
        Me.tab_valor_leitura_61.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_61.TabIndex = 2519
        Me.tab_valor_leitura_61.Text = "0"
        Me.tab_valor_leitura_61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_62
        '
        Me.tab_valor_leitura_62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_62.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_62.CausesValidation = False
        Me.tab_valor_leitura_62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_62.Location = New System.Drawing.Point(695, 31)
        Me.tab_valor_leitura_62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_62.Name = "tab_valor_leitura_62"
        Me.tab_valor_leitura_62.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_62.TabIndex = 2519
        Me.tab_valor_leitura_62.Text = "0"
        Me.tab_valor_leitura_62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_63
        '
        Me.tab_valor_leitura_63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_63.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_63.CausesValidation = False
        Me.tab_valor_leitura_63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_63.Location = New System.Drawing.Point(695, 59)
        Me.tab_valor_leitura_63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_63.Name = "tab_valor_leitura_63"
        Me.tab_valor_leitura_63.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_63.TabIndex = 2519
        Me.tab_valor_leitura_63.Text = "0"
        Me.tab_valor_leitura_63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_64
        '
        Me.tab_valor_leitura_64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_64.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_64.CausesValidation = False
        Me.tab_valor_leitura_64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_64.Location = New System.Drawing.Point(695, 87)
        Me.tab_valor_leitura_64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_64.Name = "tab_valor_leitura_64"
        Me.tab_valor_leitura_64.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_64.TabIndex = 2519
        Me.tab_valor_leitura_64.Text = "0"
        Me.tab_valor_leitura_64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_65
        '
        Me.tab_valor_leitura_65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_65.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_65.CausesValidation = False
        Me.tab_valor_leitura_65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_65.Location = New System.Drawing.Point(695, 115)
        Me.tab_valor_leitura_65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_65.Name = "tab_valor_leitura_65"
        Me.tab_valor_leitura_65.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_65.TabIndex = 2519
        Me.tab_valor_leitura_65.Text = "0"
        Me.tab_valor_leitura_65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_66
        '
        Me.tab_valor_leitura_66.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_66.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_66.CausesValidation = False
        Me.tab_valor_leitura_66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_66.Location = New System.Drawing.Point(695, 143)
        Me.tab_valor_leitura_66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_66.Name = "tab_valor_leitura_66"
        Me.tab_valor_leitura_66.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_66.TabIndex = 2519
        Me.tab_valor_leitura_66.Text = "0"
        Me.tab_valor_leitura_66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_67
        '
        Me.tab_valor_leitura_67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_67.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_67.CausesValidation = False
        Me.tab_valor_leitura_67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_67.Location = New System.Drawing.Point(695, 171)
        Me.tab_valor_leitura_67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_67.Name = "tab_valor_leitura_67"
        Me.tab_valor_leitura_67.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_67.TabIndex = 2519
        Me.tab_valor_leitura_67.Text = "0"
        Me.tab_valor_leitura_67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_68
        '
        Me.tab_valor_leitura_68.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_68.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_68.CausesValidation = False
        Me.tab_valor_leitura_68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_68.Location = New System.Drawing.Point(695, 199)
        Me.tab_valor_leitura_68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_68.Name = "tab_valor_leitura_68"
        Me.tab_valor_leitura_68.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_68.TabIndex = 2519
        Me.tab_valor_leitura_68.Text = "0"
        Me.tab_valor_leitura_68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_69
        '
        Me.tab_valor_leitura_69.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_69.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_69.CausesValidation = False
        Me.tab_valor_leitura_69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_69.Location = New System.Drawing.Point(695, 227)
        Me.tab_valor_leitura_69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_69.Name = "tab_valor_leitura_69"
        Me.tab_valor_leitura_69.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_69.TabIndex = 2519
        Me.tab_valor_leitura_69.Text = "0"
        Me.tab_valor_leitura_69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_70
        '
        Me.tab_valor_leitura_70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_70.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_70.CausesValidation = False
        Me.tab_valor_leitura_70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_70.Location = New System.Drawing.Point(695, 255)
        Me.tab_valor_leitura_70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_70.Name = "tab_valor_leitura_70"
        Me.tab_valor_leitura_70.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_70.TabIndex = 2519
        Me.tab_valor_leitura_70.Text = "0"
        Me.tab_valor_leitura_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_71
        '
        Me.tab_valor_leitura_71.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_71.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_71.CausesValidation = False
        Me.tab_valor_leitura_71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_71.Location = New System.Drawing.Point(695, 283)
        Me.tab_valor_leitura_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_71.Name = "tab_valor_leitura_71"
        Me.tab_valor_leitura_71.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_71.TabIndex = 2519
        Me.tab_valor_leitura_71.Text = "0"
        Me.tab_valor_leitura_71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_72
        '
        Me.tab_valor_leitura_72.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_72.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_72.CausesValidation = False
        Me.tab_valor_leitura_72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_72.Location = New System.Drawing.Point(695, 311)
        Me.tab_valor_leitura_72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_72.Name = "tab_valor_leitura_72"
        Me.tab_valor_leitura_72.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_72.TabIndex = 2519
        Me.tab_valor_leitura_72.Text = "0"
        Me.tab_valor_leitura_72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_73
        '
        Me.tab_valor_leitura_73.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_73.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_73.CausesValidation = False
        Me.tab_valor_leitura_73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_73.Location = New System.Drawing.Point(695, 339)
        Me.tab_valor_leitura_73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_73.Name = "tab_valor_leitura_73"
        Me.tab_valor_leitura_73.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_73.TabIndex = 2519
        Me.tab_valor_leitura_73.Text = "0"
        Me.tab_valor_leitura_73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_74
        '
        Me.tab_valor_leitura_74.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_74.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_74.CausesValidation = False
        Me.tab_valor_leitura_74.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_74.Location = New System.Drawing.Point(695, 367)
        Me.tab_valor_leitura_74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_74.Name = "tab_valor_leitura_74"
        Me.tab_valor_leitura_74.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_74.TabIndex = 2519
        Me.tab_valor_leitura_74.Text = "0"
        Me.tab_valor_leitura_74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_75
        '
        Me.tab_valor_leitura_75.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_75.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_75.CausesValidation = False
        Me.tab_valor_leitura_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_75.Location = New System.Drawing.Point(695, 395)
        Me.tab_valor_leitura_75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_75.Name = "tab_valor_leitura_75"
        Me.tab_valor_leitura_75.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_75.TabIndex = 2519
        Me.tab_valor_leitura_75.Text = "0"
        Me.tab_valor_leitura_75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_76
        '
        Me.tab_valor_leitura_76.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_76.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_76.CausesValidation = False
        Me.tab_valor_leitura_76.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_76.Location = New System.Drawing.Point(695, 423)
        Me.tab_valor_leitura_76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_76.Name = "tab_valor_leitura_76"
        Me.tab_valor_leitura_76.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_76.TabIndex = 2519
        Me.tab_valor_leitura_76.Text = "0"
        Me.tab_valor_leitura_76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_77
        '
        Me.tab_valor_leitura_77.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_77.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_77.CausesValidation = False
        Me.tab_valor_leitura_77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_77.Location = New System.Drawing.Point(695, 451)
        Me.tab_valor_leitura_77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_77.Name = "tab_valor_leitura_77"
        Me.tab_valor_leitura_77.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_77.TabIndex = 2519
        Me.tab_valor_leitura_77.Text = "0"
        Me.tab_valor_leitura_77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_78
        '
        Me.tab_valor_leitura_78.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_78.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_78.CausesValidation = False
        Me.tab_valor_leitura_78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_78.Location = New System.Drawing.Point(695, 479)
        Me.tab_valor_leitura_78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_78.Name = "tab_valor_leitura_78"
        Me.tab_valor_leitura_78.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_78.TabIndex = 2519
        Me.tab_valor_leitura_78.Text = "0"
        Me.tab_valor_leitura_78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_79
        '
        Me.tab_valor_leitura_79.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_79.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_79.CausesValidation = False
        Me.tab_valor_leitura_79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_79.Location = New System.Drawing.Point(695, 507)
        Me.tab_valor_leitura_79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_79.Name = "tab_valor_leitura_79"
        Me.tab_valor_leitura_79.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_79.TabIndex = 2519
        Me.tab_valor_leitura_79.Text = "0"
        Me.tab_valor_leitura_79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_80
        '
        Me.tab_valor_leitura_80.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_80.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_80.CausesValidation = False
        Me.tab_valor_leitura_80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_80.Location = New System.Drawing.Point(695, 540)
        Me.tab_valor_leitura_80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_80.Name = "tab_valor_leitura_80"
        Me.tab_valor_leitura_80.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_80.TabIndex = 2519
        Me.tab_valor_leitura_80.Text = "0"
        Me.tab_valor_leitura_80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_83
        '
        Me.tab_valor_leitura_83.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_83.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_83.CausesValidation = False
        Me.tab_valor_leitura_83.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_83.Location = New System.Drawing.Point(919, 59)
        Me.tab_valor_leitura_83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_83.Name = "tab_valor_leitura_83"
        Me.tab_valor_leitura_83.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_83.TabIndex = 2519
        Me.tab_valor_leitura_83.Text = "0"
        Me.tab_valor_leitura_83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_84
        '
        Me.tab_valor_leitura_84.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_84.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_84.CausesValidation = False
        Me.tab_valor_leitura_84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_84.Location = New System.Drawing.Point(919, 87)
        Me.tab_valor_leitura_84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_84.Name = "tab_valor_leitura_84"
        Me.tab_valor_leitura_84.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_84.TabIndex = 2519
        Me.tab_valor_leitura_84.Text = "0"
        Me.tab_valor_leitura_84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_85
        '
        Me.tab_valor_leitura_85.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_85.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_85.CausesValidation = False
        Me.tab_valor_leitura_85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_85.Location = New System.Drawing.Point(919, 115)
        Me.tab_valor_leitura_85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_85.Name = "tab_valor_leitura_85"
        Me.tab_valor_leitura_85.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_85.TabIndex = 2519
        Me.tab_valor_leitura_85.Text = "0"
        Me.tab_valor_leitura_85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_86
        '
        Me.tab_valor_leitura_86.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_86.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_86.CausesValidation = False
        Me.tab_valor_leitura_86.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_86.Location = New System.Drawing.Point(919, 143)
        Me.tab_valor_leitura_86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_86.Name = "tab_valor_leitura_86"
        Me.tab_valor_leitura_86.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_86.TabIndex = 2519
        Me.tab_valor_leitura_86.Text = "0"
        Me.tab_valor_leitura_86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_87
        '
        Me.tab_valor_leitura_87.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_87.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_87.CausesValidation = False
        Me.tab_valor_leitura_87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_87.Location = New System.Drawing.Point(919, 171)
        Me.tab_valor_leitura_87.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_87.Name = "tab_valor_leitura_87"
        Me.tab_valor_leitura_87.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_87.TabIndex = 2519
        Me.tab_valor_leitura_87.Text = "0"
        Me.tab_valor_leitura_87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_88
        '
        Me.tab_valor_leitura_88.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_88.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_88.CausesValidation = False
        Me.tab_valor_leitura_88.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_88.Location = New System.Drawing.Point(919, 199)
        Me.tab_valor_leitura_88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_88.Name = "tab_valor_leitura_88"
        Me.tab_valor_leitura_88.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_88.TabIndex = 2519
        Me.tab_valor_leitura_88.Text = "0"
        Me.tab_valor_leitura_88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_89
        '
        Me.tab_valor_leitura_89.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_89.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_89.CausesValidation = False
        Me.tab_valor_leitura_89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_89.Location = New System.Drawing.Point(919, 227)
        Me.tab_valor_leitura_89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_89.Name = "tab_valor_leitura_89"
        Me.tab_valor_leitura_89.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_89.TabIndex = 2519
        Me.tab_valor_leitura_89.Text = "0"
        Me.tab_valor_leitura_89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_90
        '
        Me.tab_valor_leitura_90.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_90.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_90.CausesValidation = False
        Me.tab_valor_leitura_90.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_90.Location = New System.Drawing.Point(919, 255)
        Me.tab_valor_leitura_90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_90.Name = "tab_valor_leitura_90"
        Me.tab_valor_leitura_90.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_90.TabIndex = 2519
        Me.tab_valor_leitura_90.Text = "0"
        Me.tab_valor_leitura_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_91
        '
        Me.tab_valor_leitura_91.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_91.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_91.CausesValidation = False
        Me.tab_valor_leitura_91.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_91.Location = New System.Drawing.Point(919, 283)
        Me.tab_valor_leitura_91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_91.Name = "tab_valor_leitura_91"
        Me.tab_valor_leitura_91.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_91.TabIndex = 2519
        Me.tab_valor_leitura_91.Text = "0"
        Me.tab_valor_leitura_91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_92
        '
        Me.tab_valor_leitura_92.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_92.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_92.CausesValidation = False
        Me.tab_valor_leitura_92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_92.Location = New System.Drawing.Point(919, 311)
        Me.tab_valor_leitura_92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_92.Name = "tab_valor_leitura_92"
        Me.tab_valor_leitura_92.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_92.TabIndex = 2519
        Me.tab_valor_leitura_92.Text = "0"
        Me.tab_valor_leitura_92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_93
        '
        Me.tab_valor_leitura_93.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_93.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_93.CausesValidation = False
        Me.tab_valor_leitura_93.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_93.Location = New System.Drawing.Point(919, 339)
        Me.tab_valor_leitura_93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_93.Name = "tab_valor_leitura_93"
        Me.tab_valor_leitura_93.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_93.TabIndex = 2519
        Me.tab_valor_leitura_93.Text = "0"
        Me.tab_valor_leitura_93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_94
        '
        Me.tab_valor_leitura_94.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_94.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_94.CausesValidation = False
        Me.tab_valor_leitura_94.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_94.Location = New System.Drawing.Point(919, 367)
        Me.tab_valor_leitura_94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_94.Name = "tab_valor_leitura_94"
        Me.tab_valor_leitura_94.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_94.TabIndex = 2519
        Me.tab_valor_leitura_94.Text = "0"
        Me.tab_valor_leitura_94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_95
        '
        Me.tab_valor_leitura_95.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_95.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_95.CausesValidation = False
        Me.tab_valor_leitura_95.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_95.Location = New System.Drawing.Point(919, 395)
        Me.tab_valor_leitura_95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_95.Name = "tab_valor_leitura_95"
        Me.tab_valor_leitura_95.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_95.TabIndex = 2519
        Me.tab_valor_leitura_95.Text = "0"
        Me.tab_valor_leitura_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_96
        '
        Me.tab_valor_leitura_96.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_96.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_96.CausesValidation = False
        Me.tab_valor_leitura_96.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_96.Location = New System.Drawing.Point(919, 423)
        Me.tab_valor_leitura_96.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_96.Name = "tab_valor_leitura_96"
        Me.tab_valor_leitura_96.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_96.TabIndex = 2519
        Me.tab_valor_leitura_96.Text = "0"
        Me.tab_valor_leitura_96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_97
        '
        Me.tab_valor_leitura_97.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_97.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_97.CausesValidation = False
        Me.tab_valor_leitura_97.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_97.Location = New System.Drawing.Point(919, 451)
        Me.tab_valor_leitura_97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_97.Name = "tab_valor_leitura_97"
        Me.tab_valor_leitura_97.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_97.TabIndex = 2519
        Me.tab_valor_leitura_97.Text = "0"
        Me.tab_valor_leitura_97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_98
        '
        Me.tab_valor_leitura_98.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_98.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_98.CausesValidation = False
        Me.tab_valor_leitura_98.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_98.Location = New System.Drawing.Point(919, 479)
        Me.tab_valor_leitura_98.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_98.Name = "tab_valor_leitura_98"
        Me.tab_valor_leitura_98.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_98.TabIndex = 2519
        Me.tab_valor_leitura_98.Text = "0"
        Me.tab_valor_leitura_98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_99
        '
        Me.tab_valor_leitura_99.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_99.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_99.CausesValidation = False
        Me.tab_valor_leitura_99.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_99.Location = New System.Drawing.Point(919, 507)
        Me.tab_valor_leitura_99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_99.Name = "tab_valor_leitura_99"
        Me.tab_valor_leitura_99.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_99.TabIndex = 2519
        Me.tab_valor_leitura_99.Text = "0"
        Me.tab_valor_leitura_99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_100
        '
        Me.tab_valor_leitura_100.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_100.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_100.CausesValidation = False
        Me.tab_valor_leitura_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_100.Location = New System.Drawing.Point(919, 540)
        Me.tab_valor_leitura_100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_100.Name = "tab_valor_leitura_100"
        Me.tab_valor_leitura_100.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_100.TabIndex = 2519
        Me.tab_valor_leitura_100.Text = "0"
        Me.tab_valor_leitura_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_81
        '
        Me.tab_valor_leitura_81.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_81.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_81.CausesValidation = False
        Me.tab_valor_leitura_81.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_81.Location = New System.Drawing.Point(919, 31)
        Me.tab_valor_leitura_81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_81.Name = "tab_valor_leitura_81"
        Me.tab_valor_leitura_81.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_81.TabIndex = 2519
        Me.tab_valor_leitura_81.Text = "0"
        Me.tab_valor_leitura_81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_leitura_82
        '
        Me.tab_valor_leitura_82.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_leitura_82.BackColor = System.Drawing.Color.White
        Me.tab_valor_leitura_82.CausesValidation = False
        Me.tab_valor_leitura_82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_leitura_82.Location = New System.Drawing.Point(919, 3)
        Me.tab_valor_leitura_82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_leitura_82.Name = "tab_valor_leitura_82"
        Me.tab_valor_leitura_82.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_leitura_82.TabIndex = 2519
        Me.tab_valor_leitura_82.Text = "0"
        Me.tab_valor_leitura_82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_leitura
        '
        Me.Panel_leitura.BackColor = System.Drawing.Color.White
        Me.Panel_leitura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_leitura.Controls.Add(Me.BT_entra_sel)
        Me.Panel_leitura.Controls.Add(Me.BT_fecha)
        Me.Panel_leitura.Controls.Add(Me.Label2)
        Me.Panel_leitura.Controls.Add(Me.Label9)
        Me.Panel_leitura.Controls.Add(Me.reg_sel)
        Me.Panel_leitura.Controls.Add(Me.valor_sel)
        Me.Panel_leitura.Controls.Add(Me.RadioButton_decrementa)
        Me.Panel_leitura.Controls.Add(Me.RadioButton_Normal)
        Me.Panel_leitura.Controls.Add(Me.RadioButton_Incrementa)
        Me.Panel_leitura.Location = New System.Drawing.Point(1113, 76)
        Me.Panel_leitura.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_leitura.Name = "Panel_leitura"
        Me.Panel_leitura.Size = New System.Drawing.Size(259, 254)
        Me.Panel_leitura.TabIndex = 2517
        '
        'BT_entra_sel
        '
        Me.BT_entra_sel.Location = New System.Drawing.Point(151, 92)
        Me.BT_entra_sel.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_entra_sel.Name = "BT_entra_sel"
        Me.BT_entra_sel.Size = New System.Drawing.Size(92, 25)
        Me.BT_entra_sel.TabIndex = 2516
        Me.BT_entra_sel.Text = "Entra"
        Me.BT_entra_sel.UseVisualStyleBackColor = True
        '
        'BT_fecha
        '
        Me.BT_fecha.Location = New System.Drawing.Point(159, 210)
        Me.BT_fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_fecha.Name = "BT_fecha"
        Me.BT_fecha.Size = New System.Drawing.Size(84, 25)
        Me.BT_fecha.TabIndex = 2515
        Me.BT_fecha.Text = "Fecha"
        Me.BT_fecha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(43, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2514
        Me.Label2.Text = "Valor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(13, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 2514
        Me.Label9.Text = "Registro"
        '
        'reg_sel
        '
        Me.reg_sel.AutoSize = True
        Me.reg_sel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_sel.Location = New System.Drawing.Point(124, 11)
        Me.reg_sel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.reg_sel.Name = "reg_sel"
        Me.reg_sel.Size = New System.Drawing.Size(19, 20)
        Me.reg_sel.TabIndex = 2514
        Me.reg_sel.Text = "0"
        '
        'valor_sel
        '
        Me.valor_sel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.valor_sel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor_sel.Location = New System.Drawing.Point(129, 58)
        Me.valor_sel.Margin = New System.Windows.Forms.Padding(4)
        Me.valor_sel.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.valor_sel.Name = "valor_sel"
        Me.valor_sel.Size = New System.Drawing.Size(100, 26)
        Me.valor_sel.TabIndex = 2512
        '
        'RadioButton_decrementa
        '
        Me.RadioButton_decrementa.AutoSize = True
        Me.RadioButton_decrementa.Location = New System.Drawing.Point(27, 194)
        Me.RadioButton_decrementa.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_decrementa.Name = "RadioButton_decrementa"
        Me.RadioButton_decrementa.Size = New System.Drawing.Size(106, 21)
        Me.RadioButton_decrementa.TabIndex = 2513
        Me.RadioButton_decrementa.TabStop = True
        Me.RadioButton_decrementa.Text = "Decrementa"
        Me.RadioButton_decrementa.UseVisualStyleBackColor = True
        '
        'RadioButton_Normal
        '
        Me.RadioButton_Normal.AutoSize = True
        Me.RadioButton_Normal.Location = New System.Drawing.Point(27, 166)
        Me.RadioButton_Normal.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Normal.Name = "RadioButton_Normal"
        Me.RadioButton_Normal.Size = New System.Drawing.Size(74, 21)
        Me.RadioButton_Normal.TabIndex = 2513
        Me.RadioButton_Normal.TabStop = True
        Me.RadioButton_Normal.Text = "Normal"
        Me.RadioButton_Normal.UseVisualStyleBackColor = True
        '
        'RadioButton_Incrementa
        '
        Me.RadioButton_Incrementa.AutoSize = True
        Me.RadioButton_Incrementa.Location = New System.Drawing.Point(27, 138)
        Me.RadioButton_Incrementa.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton_Incrementa.Name = "RadioButton_Incrementa"
        Me.RadioButton_Incrementa.Size = New System.Drawing.Size(99, 21)
        Me.RadioButton_Incrementa.TabIndex = 2513
        Me.RadioButton_Incrementa.TabStop = True
        Me.RadioButton_Incrementa.Text = "Incrementa"
        Me.RadioButton_Incrementa.UseVisualStyleBackColor = True
        '
        'tab_leitura_inicio
        '
        Me.tab_leitura_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_leitura_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_leitura_inicio.Location = New System.Drawing.Point(33, 33)
        Me.tab_leitura_inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_leitura_inicio.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.tab_leitura_inicio.Name = "tab_leitura_inicio"
        Me.tab_leitura_inicio.Size = New System.Drawing.Size(100, 26)
        Me.tab_leitura_inicio.TabIndex = 2512
        '
        'Escrita
        '
        Me.Escrita.BackColor = System.Drawing.Color.White
        Me.Escrita.Controls.Add(Me.Label216)
        Me.Escrita.Controls.Add(Me.tab_escrita_inicio)
        Me.Escrita.Controls.Add(Me.TableLayoutPanel2)
        Me.Escrita.Location = New System.Drawing.Point(4, 28)
        Me.Escrita.Margin = New System.Windows.Forms.Padding(4)
        Me.Escrita.Name = "Escrita"
        Me.Escrita.Padding = New System.Windows.Forms.Padding(4)
        Me.Escrita.Size = New System.Drawing.Size(1404, 791)
        Me.Escrita.TabIndex = 2
        Me.Escrita.Text = "Escrita"
        '
        'Label216
        '
        Me.Label216.AutoSize = True
        Me.Label216.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label216.Location = New System.Drawing.Point(139, 37)
        Me.Label216.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label216.Name = "Label216"
        Me.Label216.Size = New System.Drawing.Size(54, 20)
        Me.Label216.TabIndex = 2524
        Me.Label216.Text = "Inicio"
        '
        'tab_escrita_inicio
        '
        Me.tab_escrita_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_escrita_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_escrita_inicio.Location = New System.Drawing.Point(33, 33)
        Me.tab_escrita_inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_escrita_inicio.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.tab_escrita_inicio.Name = "tab_escrita_inicio"
        Me.tab_escrita_inicio.Size = New System.Drawing.Size(100, 26)
        Me.tab_escrita_inicio.TabIndex = 2523
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AllowDrop = True
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel2.ColumnCount = 10
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_7, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_8, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_9, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_10, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_11, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_12, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_13, 0, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_14, 0, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_15, 0, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_16, 0, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_17, 0, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_18, 0, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_19, 0, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_20, 0, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_21, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_22, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_23, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_24, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_25, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_26, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_27, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_28, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_29, 2, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_30, 2, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_31, 2, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_32, 2, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_33, 2, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_34, 2, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_35, 2, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_36, 2, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_37, 2, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_38, 2, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_39, 2, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_40, 2, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_41, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_42, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_43, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_44, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_45, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_46, 4, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_47, 4, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_48, 4, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_49, 4, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_50, 4, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_51, 4, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_52, 4, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_53, 4, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_54, 4, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_55, 4, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_56, 4, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_57, 4, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_58, 4, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_59, 4, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_60, 4, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_61, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_62, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_63, 6, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_64, 6, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_65, 6, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_66, 6, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_67, 6, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_68, 6, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_69, 6, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_70, 6, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_71, 6, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_72, 6, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_73, 6, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_74, 6, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_75, 6, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_76, 6, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_77, 6, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_78, 6, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_79, 6, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_80, 6, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_81, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_82, 8, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_83, 8, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_84, 8, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_85, 8, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_86, 8, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_87, 8, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_88, 8, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_89, 8, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_90, 8, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_91, 8, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_92, 8, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_93, 8, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_94, 8, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_95, 8, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_96, 8, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_97, 8, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_98, 8, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_99, 8, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_endereco_escrita_100, 8, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_4, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_5, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_6, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_7, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_8, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_9, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_10, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_11, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_12, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_13, 1, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_14, 1, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_15, 1, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_16, 1, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_17, 1, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_18, 1, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_19, 1, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_20, 1, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_21, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_22, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_23, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_24, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_25, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_26, 3, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_27, 3, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_28, 3, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_29, 3, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_30, 3, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_31, 3, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_32, 3, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_33, 3, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_34, 3, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_35, 3, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_36, 3, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_37, 3, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_38, 3, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_39, 3, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_40, 3, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_41, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_42, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_43, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_44, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_45, 5, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_46, 5, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_47, 5, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_48, 5, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_49, 5, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_50, 5, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_51, 5, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_52, 5, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_53, 5, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_54, 5, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_55, 5, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_56, 5, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_57, 5, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_58, 5, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_59, 5, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_60, 5, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_61, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_62, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_63, 7, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_64, 7, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_65, 7, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_66, 7, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_67, 7, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_68, 7, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_69, 7, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_70, 7, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_71, 7, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_72, 7, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_73, 7, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_74, 7, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_75, 7, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_76, 7, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_77, 7, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_78, 7, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_79, 7, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_80, 7, 19)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_81, 9, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_82, 9, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_83, 9, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_84, 9, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_85, 9, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_86, 9, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_87, 9, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_88, 9, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_89, 9, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_90, 9, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_91, 9, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_92, 9, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_93, 9, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_94, 9, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_95, 9, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_96, 9, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_97, 9, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_98, 9, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_99, 9, 18)
        Me.TableLayoutPanel2.Controls.Add(Me.tab_valor_escrita_100, 9, 19)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(31, 76)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 20
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1063, 574)
        Me.TableLayoutPanel2.TabIndex = 2522
        '
        'tab_endereco_escrita_1
        '
        Me.tab_endereco_escrita_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_1.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_1.CausesValidation = False
        Me.tab_endereco_escrita_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_1.Location = New System.Drawing.Point(7, 3)
        Me.tab_endereco_escrita_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_1.Name = "tab_endereco_escrita_1"
        Me.tab_endereco_escrita_1.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_1.TabIndex = 2519
        Me.tab_endereco_escrita_1.Text = "0"
        Me.tab_endereco_escrita_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_2
        '
        Me.tab_endereco_escrita_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_2.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_2.CausesValidation = False
        Me.tab_endereco_escrita_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_2.Location = New System.Drawing.Point(7, 31)
        Me.tab_endereco_escrita_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_2.Name = "tab_endereco_escrita_2"
        Me.tab_endereco_escrita_2.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_2.TabIndex = 2519
        Me.tab_endereco_escrita_2.Text = "0"
        Me.tab_endereco_escrita_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_3
        '
        Me.tab_endereco_escrita_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_3.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_3.CausesValidation = False
        Me.tab_endereco_escrita_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_3.Location = New System.Drawing.Point(7, 59)
        Me.tab_endereco_escrita_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_3.Name = "tab_endereco_escrita_3"
        Me.tab_endereco_escrita_3.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_3.TabIndex = 2519
        Me.tab_endereco_escrita_3.Text = "0"
        Me.tab_endereco_escrita_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_4
        '
        Me.tab_endereco_escrita_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_4.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_4.CausesValidation = False
        Me.tab_endereco_escrita_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_4.Location = New System.Drawing.Point(7, 87)
        Me.tab_endereco_escrita_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_4.Name = "tab_endereco_escrita_4"
        Me.tab_endereco_escrita_4.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_4.TabIndex = 2519
        Me.tab_endereco_escrita_4.Text = "0"
        Me.tab_endereco_escrita_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_5
        '
        Me.tab_endereco_escrita_5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_5.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_5.CausesValidation = False
        Me.tab_endereco_escrita_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_5.Location = New System.Drawing.Point(7, 115)
        Me.tab_endereco_escrita_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_5.Name = "tab_endereco_escrita_5"
        Me.tab_endereco_escrita_5.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_5.TabIndex = 2519
        Me.tab_endereco_escrita_5.Text = "0"
        Me.tab_endereco_escrita_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_6
        '
        Me.tab_endereco_escrita_6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_6.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_6.CausesValidation = False
        Me.tab_endereco_escrita_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_6.Location = New System.Drawing.Point(7, 143)
        Me.tab_endereco_escrita_6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_6.Name = "tab_endereco_escrita_6"
        Me.tab_endereco_escrita_6.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_6.TabIndex = 2519
        Me.tab_endereco_escrita_6.Text = "0"
        Me.tab_endereco_escrita_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_7
        '
        Me.tab_endereco_escrita_7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_7.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_7.CausesValidation = False
        Me.tab_endereco_escrita_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_7.Location = New System.Drawing.Point(7, 171)
        Me.tab_endereco_escrita_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_7.Name = "tab_endereco_escrita_7"
        Me.tab_endereco_escrita_7.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_7.TabIndex = 2519
        Me.tab_endereco_escrita_7.Text = "0"
        Me.tab_endereco_escrita_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_8
        '
        Me.tab_endereco_escrita_8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_8.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_8.CausesValidation = False
        Me.tab_endereco_escrita_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_8.Location = New System.Drawing.Point(7, 199)
        Me.tab_endereco_escrita_8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_8.Name = "tab_endereco_escrita_8"
        Me.tab_endereco_escrita_8.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_8.TabIndex = 2519
        Me.tab_endereco_escrita_8.Text = "0"
        Me.tab_endereco_escrita_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_9
        '
        Me.tab_endereco_escrita_9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_9.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_9.CausesValidation = False
        Me.tab_endereco_escrita_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_9.Location = New System.Drawing.Point(7, 227)
        Me.tab_endereco_escrita_9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_9.Name = "tab_endereco_escrita_9"
        Me.tab_endereco_escrita_9.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_9.TabIndex = 2519
        Me.tab_endereco_escrita_9.Text = "0"
        Me.tab_endereco_escrita_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_10
        '
        Me.tab_endereco_escrita_10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_10.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_10.CausesValidation = False
        Me.tab_endereco_escrita_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_10.Location = New System.Drawing.Point(7, 255)
        Me.tab_endereco_escrita_10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_10.Name = "tab_endereco_escrita_10"
        Me.tab_endereco_escrita_10.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_10.TabIndex = 2519
        Me.tab_endereco_escrita_10.Text = "0"
        Me.tab_endereco_escrita_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_11
        '
        Me.tab_endereco_escrita_11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_11.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_11.CausesValidation = False
        Me.tab_endereco_escrita_11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_11.Location = New System.Drawing.Point(7, 283)
        Me.tab_endereco_escrita_11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_11.Name = "tab_endereco_escrita_11"
        Me.tab_endereco_escrita_11.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_11.TabIndex = 2519
        Me.tab_endereco_escrita_11.Text = "0"
        Me.tab_endereco_escrita_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_12
        '
        Me.tab_endereco_escrita_12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_12.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_12.CausesValidation = False
        Me.tab_endereco_escrita_12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_12.Location = New System.Drawing.Point(7, 311)
        Me.tab_endereco_escrita_12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_12.Name = "tab_endereco_escrita_12"
        Me.tab_endereco_escrita_12.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_12.TabIndex = 2519
        Me.tab_endereco_escrita_12.Text = "0"
        Me.tab_endereco_escrita_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_13
        '
        Me.tab_endereco_escrita_13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_13.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_13.CausesValidation = False
        Me.tab_endereco_escrita_13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_13.Location = New System.Drawing.Point(7, 339)
        Me.tab_endereco_escrita_13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_13.Name = "tab_endereco_escrita_13"
        Me.tab_endereco_escrita_13.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_13.TabIndex = 2519
        Me.tab_endereco_escrita_13.Text = "0"
        Me.tab_endereco_escrita_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_14
        '
        Me.tab_endereco_escrita_14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_14.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_14.CausesValidation = False
        Me.tab_endereco_escrita_14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_14.Location = New System.Drawing.Point(7, 367)
        Me.tab_endereco_escrita_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_14.Name = "tab_endereco_escrita_14"
        Me.tab_endereco_escrita_14.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_14.TabIndex = 2519
        Me.tab_endereco_escrita_14.Text = "0"
        Me.tab_endereco_escrita_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_15
        '
        Me.tab_endereco_escrita_15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_15.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_15.CausesValidation = False
        Me.tab_endereco_escrita_15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_15.Location = New System.Drawing.Point(7, 395)
        Me.tab_endereco_escrita_15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_15.Name = "tab_endereco_escrita_15"
        Me.tab_endereco_escrita_15.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_15.TabIndex = 2519
        Me.tab_endereco_escrita_15.Text = "0"
        Me.tab_endereco_escrita_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_16
        '
        Me.tab_endereco_escrita_16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_16.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_16.CausesValidation = False
        Me.tab_endereco_escrita_16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_16.Location = New System.Drawing.Point(7, 423)
        Me.tab_endereco_escrita_16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_16.Name = "tab_endereco_escrita_16"
        Me.tab_endereco_escrita_16.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_16.TabIndex = 2519
        Me.tab_endereco_escrita_16.Text = "0"
        Me.tab_endereco_escrita_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_17
        '
        Me.tab_endereco_escrita_17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_17.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_17.CausesValidation = False
        Me.tab_endereco_escrita_17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_17.Location = New System.Drawing.Point(7, 451)
        Me.tab_endereco_escrita_17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_17.Name = "tab_endereco_escrita_17"
        Me.tab_endereco_escrita_17.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_17.TabIndex = 2519
        Me.tab_endereco_escrita_17.Text = "0"
        Me.tab_endereco_escrita_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_18
        '
        Me.tab_endereco_escrita_18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_18.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_18.CausesValidation = False
        Me.tab_endereco_escrita_18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_18.Location = New System.Drawing.Point(7, 479)
        Me.tab_endereco_escrita_18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_18.Name = "tab_endereco_escrita_18"
        Me.tab_endereco_escrita_18.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_18.TabIndex = 2519
        Me.tab_endereco_escrita_18.Text = "0"
        Me.tab_endereco_escrita_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_19
        '
        Me.tab_endereco_escrita_19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_19.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_19.CausesValidation = False
        Me.tab_endereco_escrita_19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_19.Location = New System.Drawing.Point(7, 507)
        Me.tab_endereco_escrita_19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_19.Name = "tab_endereco_escrita_19"
        Me.tab_endereco_escrita_19.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_19.TabIndex = 2519
        Me.tab_endereco_escrita_19.Text = "0"
        Me.tab_endereco_escrita_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_20
        '
        Me.tab_endereco_escrita_20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_20.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_20.CausesValidation = False
        Me.tab_endereco_escrita_20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_20.Location = New System.Drawing.Point(7, 540)
        Me.tab_endereco_escrita_20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_20.Name = "tab_endereco_escrita_20"
        Me.tab_endereco_escrita_20.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_20.TabIndex = 2519
        Me.tab_endereco_escrita_20.Text = "0"
        Me.tab_endereco_escrita_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_21
        '
        Me.tab_endereco_escrita_21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_21.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_21.CausesValidation = False
        Me.tab_endereco_escrita_21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_21.Location = New System.Drawing.Point(213, 3)
        Me.tab_endereco_escrita_21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_21.Name = "tab_endereco_escrita_21"
        Me.tab_endereco_escrita_21.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_21.TabIndex = 2519
        Me.tab_endereco_escrita_21.Text = "0"
        Me.tab_endereco_escrita_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_22
        '
        Me.tab_endereco_escrita_22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_22.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_22.CausesValidation = False
        Me.tab_endereco_escrita_22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_22.Location = New System.Drawing.Point(213, 31)
        Me.tab_endereco_escrita_22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_22.Name = "tab_endereco_escrita_22"
        Me.tab_endereco_escrita_22.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_22.TabIndex = 2519
        Me.tab_endereco_escrita_22.Text = "0"
        Me.tab_endereco_escrita_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_23
        '
        Me.tab_endereco_escrita_23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_23.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_23.CausesValidation = False
        Me.tab_endereco_escrita_23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_23.Location = New System.Drawing.Point(213, 59)
        Me.tab_endereco_escrita_23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_23.Name = "tab_endereco_escrita_23"
        Me.tab_endereco_escrita_23.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_23.TabIndex = 2519
        Me.tab_endereco_escrita_23.Text = "0"
        Me.tab_endereco_escrita_23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_24
        '
        Me.tab_endereco_escrita_24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_24.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_24.CausesValidation = False
        Me.tab_endereco_escrita_24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_24.Location = New System.Drawing.Point(213, 87)
        Me.tab_endereco_escrita_24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_24.Name = "tab_endereco_escrita_24"
        Me.tab_endereco_escrita_24.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_24.TabIndex = 2519
        Me.tab_endereco_escrita_24.Text = "0"
        Me.tab_endereco_escrita_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_25
        '
        Me.tab_endereco_escrita_25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_25.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_25.CausesValidation = False
        Me.tab_endereco_escrita_25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_25.Location = New System.Drawing.Point(213, 115)
        Me.tab_endereco_escrita_25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_25.Name = "tab_endereco_escrita_25"
        Me.tab_endereco_escrita_25.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_25.TabIndex = 2519
        Me.tab_endereco_escrita_25.Text = "0"
        Me.tab_endereco_escrita_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_26
        '
        Me.tab_endereco_escrita_26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_26.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_26.CausesValidation = False
        Me.tab_endereco_escrita_26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_26.Location = New System.Drawing.Point(213, 143)
        Me.tab_endereco_escrita_26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_26.Name = "tab_endereco_escrita_26"
        Me.tab_endereco_escrita_26.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_26.TabIndex = 2519
        Me.tab_endereco_escrita_26.Text = "0"
        Me.tab_endereco_escrita_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_27
        '
        Me.tab_endereco_escrita_27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_27.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_27.CausesValidation = False
        Me.tab_endereco_escrita_27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_27.Location = New System.Drawing.Point(213, 171)
        Me.tab_endereco_escrita_27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_27.Name = "tab_endereco_escrita_27"
        Me.tab_endereco_escrita_27.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_27.TabIndex = 2519
        Me.tab_endereco_escrita_27.Text = "0"
        Me.tab_endereco_escrita_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_28
        '
        Me.tab_endereco_escrita_28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_28.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_28.CausesValidation = False
        Me.tab_endereco_escrita_28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_28.Location = New System.Drawing.Point(213, 199)
        Me.tab_endereco_escrita_28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_28.Name = "tab_endereco_escrita_28"
        Me.tab_endereco_escrita_28.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_28.TabIndex = 2519
        Me.tab_endereco_escrita_28.Text = "0"
        Me.tab_endereco_escrita_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_29
        '
        Me.tab_endereco_escrita_29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_29.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_29.CausesValidation = False
        Me.tab_endereco_escrita_29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_29.Location = New System.Drawing.Point(213, 227)
        Me.tab_endereco_escrita_29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_29.Name = "tab_endereco_escrita_29"
        Me.tab_endereco_escrita_29.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_29.TabIndex = 2519
        Me.tab_endereco_escrita_29.Text = "0"
        Me.tab_endereco_escrita_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_30
        '
        Me.tab_endereco_escrita_30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_30.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_30.CausesValidation = False
        Me.tab_endereco_escrita_30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_30.Location = New System.Drawing.Point(213, 255)
        Me.tab_endereco_escrita_30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_30.Name = "tab_endereco_escrita_30"
        Me.tab_endereco_escrita_30.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_30.TabIndex = 2519
        Me.tab_endereco_escrita_30.Text = "0"
        Me.tab_endereco_escrita_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_31
        '
        Me.tab_endereco_escrita_31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_31.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_31.CausesValidation = False
        Me.tab_endereco_escrita_31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_31.Location = New System.Drawing.Point(213, 283)
        Me.tab_endereco_escrita_31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_31.Name = "tab_endereco_escrita_31"
        Me.tab_endereco_escrita_31.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_31.TabIndex = 2519
        Me.tab_endereco_escrita_31.Text = "0"
        Me.tab_endereco_escrita_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_32
        '
        Me.tab_endereco_escrita_32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_32.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_32.CausesValidation = False
        Me.tab_endereco_escrita_32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_32.Location = New System.Drawing.Point(213, 311)
        Me.tab_endereco_escrita_32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_32.Name = "tab_endereco_escrita_32"
        Me.tab_endereco_escrita_32.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_32.TabIndex = 2519
        Me.tab_endereco_escrita_32.Text = "0"
        Me.tab_endereco_escrita_32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_33
        '
        Me.tab_endereco_escrita_33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_33.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_33.CausesValidation = False
        Me.tab_endereco_escrita_33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_33.Location = New System.Drawing.Point(213, 339)
        Me.tab_endereco_escrita_33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_33.Name = "tab_endereco_escrita_33"
        Me.tab_endereco_escrita_33.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_33.TabIndex = 2519
        Me.tab_endereco_escrita_33.Text = "0"
        Me.tab_endereco_escrita_33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_34
        '
        Me.tab_endereco_escrita_34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_34.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_34.CausesValidation = False
        Me.tab_endereco_escrita_34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_34.Location = New System.Drawing.Point(213, 367)
        Me.tab_endereco_escrita_34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_34.Name = "tab_endereco_escrita_34"
        Me.tab_endereco_escrita_34.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_34.TabIndex = 2519
        Me.tab_endereco_escrita_34.Text = "0"
        Me.tab_endereco_escrita_34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_35
        '
        Me.tab_endereco_escrita_35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_35.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_35.CausesValidation = False
        Me.tab_endereco_escrita_35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_35.Location = New System.Drawing.Point(213, 395)
        Me.tab_endereco_escrita_35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_35.Name = "tab_endereco_escrita_35"
        Me.tab_endereco_escrita_35.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_35.TabIndex = 2519
        Me.tab_endereco_escrita_35.Text = "0"
        Me.tab_endereco_escrita_35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_36
        '
        Me.tab_endereco_escrita_36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_36.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_36.CausesValidation = False
        Me.tab_endereco_escrita_36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_36.Location = New System.Drawing.Point(213, 423)
        Me.tab_endereco_escrita_36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_36.Name = "tab_endereco_escrita_36"
        Me.tab_endereco_escrita_36.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_36.TabIndex = 2519
        Me.tab_endereco_escrita_36.Text = "0"
        Me.tab_endereco_escrita_36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_37
        '
        Me.tab_endereco_escrita_37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_37.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_37.CausesValidation = False
        Me.tab_endereco_escrita_37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_37.Location = New System.Drawing.Point(213, 451)
        Me.tab_endereco_escrita_37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_37.Name = "tab_endereco_escrita_37"
        Me.tab_endereco_escrita_37.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_37.TabIndex = 2519
        Me.tab_endereco_escrita_37.Text = "0"
        Me.tab_endereco_escrita_37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_38
        '
        Me.tab_endereco_escrita_38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_38.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_38.CausesValidation = False
        Me.tab_endereco_escrita_38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_38.Location = New System.Drawing.Point(213, 479)
        Me.tab_endereco_escrita_38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_38.Name = "tab_endereco_escrita_38"
        Me.tab_endereco_escrita_38.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_38.TabIndex = 2519
        Me.tab_endereco_escrita_38.Text = "0"
        Me.tab_endereco_escrita_38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_39
        '
        Me.tab_endereco_escrita_39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_39.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_39.CausesValidation = False
        Me.tab_endereco_escrita_39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_39.Location = New System.Drawing.Point(213, 507)
        Me.tab_endereco_escrita_39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_39.Name = "tab_endereco_escrita_39"
        Me.tab_endereco_escrita_39.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_39.TabIndex = 2519
        Me.tab_endereco_escrita_39.Text = "0"
        Me.tab_endereco_escrita_39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_40
        '
        Me.tab_endereco_escrita_40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_40.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_40.CausesValidation = False
        Me.tab_endereco_escrita_40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_40.Location = New System.Drawing.Point(213, 540)
        Me.tab_endereco_escrita_40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_40.Name = "tab_endereco_escrita_40"
        Me.tab_endereco_escrita_40.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_40.TabIndex = 2519
        Me.tab_endereco_escrita_40.Text = "0"
        Me.tab_endereco_escrita_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_41
        '
        Me.tab_endereco_escrita_41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_41.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_41.CausesValidation = False
        Me.tab_endereco_escrita_41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_41.Location = New System.Drawing.Point(419, 3)
        Me.tab_endereco_escrita_41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_41.Name = "tab_endereco_escrita_41"
        Me.tab_endereco_escrita_41.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_41.TabIndex = 2519
        Me.tab_endereco_escrita_41.Text = "0"
        Me.tab_endereco_escrita_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_42
        '
        Me.tab_endereco_escrita_42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_42.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_42.CausesValidation = False
        Me.tab_endereco_escrita_42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_42.Location = New System.Drawing.Point(419, 31)
        Me.tab_endereco_escrita_42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_42.Name = "tab_endereco_escrita_42"
        Me.tab_endereco_escrita_42.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_42.TabIndex = 2519
        Me.tab_endereco_escrita_42.Text = "0"
        Me.tab_endereco_escrita_42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_43
        '
        Me.tab_endereco_escrita_43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_43.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_43.CausesValidation = False
        Me.tab_endereco_escrita_43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_43.Location = New System.Drawing.Point(419, 59)
        Me.tab_endereco_escrita_43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_43.Name = "tab_endereco_escrita_43"
        Me.tab_endereco_escrita_43.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_43.TabIndex = 2519
        Me.tab_endereco_escrita_43.Text = "0"
        Me.tab_endereco_escrita_43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_44
        '
        Me.tab_endereco_escrita_44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_44.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_44.CausesValidation = False
        Me.tab_endereco_escrita_44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_44.Location = New System.Drawing.Point(419, 87)
        Me.tab_endereco_escrita_44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_44.Name = "tab_endereco_escrita_44"
        Me.tab_endereco_escrita_44.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_44.TabIndex = 2519
        Me.tab_endereco_escrita_44.Text = "0"
        Me.tab_endereco_escrita_44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_45
        '
        Me.tab_endereco_escrita_45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_45.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_45.CausesValidation = False
        Me.tab_endereco_escrita_45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_45.Location = New System.Drawing.Point(419, 115)
        Me.tab_endereco_escrita_45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_45.Name = "tab_endereco_escrita_45"
        Me.tab_endereco_escrita_45.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_45.TabIndex = 2519
        Me.tab_endereco_escrita_45.Text = "0"
        Me.tab_endereco_escrita_45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_46
        '
        Me.tab_endereco_escrita_46.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_46.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_46.CausesValidation = False
        Me.tab_endereco_escrita_46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_46.Location = New System.Drawing.Point(419, 143)
        Me.tab_endereco_escrita_46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_46.Name = "tab_endereco_escrita_46"
        Me.tab_endereco_escrita_46.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_46.TabIndex = 2519
        Me.tab_endereco_escrita_46.Text = "0"
        Me.tab_endereco_escrita_46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_47
        '
        Me.tab_endereco_escrita_47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_47.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_47.CausesValidation = False
        Me.tab_endereco_escrita_47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_47.Location = New System.Drawing.Point(419, 171)
        Me.tab_endereco_escrita_47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_47.Name = "tab_endereco_escrita_47"
        Me.tab_endereco_escrita_47.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_47.TabIndex = 2519
        Me.tab_endereco_escrita_47.Text = "0"
        Me.tab_endereco_escrita_47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_48
        '
        Me.tab_endereco_escrita_48.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_48.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_48.CausesValidation = False
        Me.tab_endereco_escrita_48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_48.Location = New System.Drawing.Point(419, 199)
        Me.tab_endereco_escrita_48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_48.Name = "tab_endereco_escrita_48"
        Me.tab_endereco_escrita_48.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_48.TabIndex = 2519
        Me.tab_endereco_escrita_48.Text = "0"
        Me.tab_endereco_escrita_48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_49
        '
        Me.tab_endereco_escrita_49.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_49.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_49.CausesValidation = False
        Me.tab_endereco_escrita_49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_49.Location = New System.Drawing.Point(419, 227)
        Me.tab_endereco_escrita_49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_49.Name = "tab_endereco_escrita_49"
        Me.tab_endereco_escrita_49.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_49.TabIndex = 2519
        Me.tab_endereco_escrita_49.Text = "0"
        Me.tab_endereco_escrita_49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_50
        '
        Me.tab_endereco_escrita_50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_50.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_50.CausesValidation = False
        Me.tab_endereco_escrita_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_50.Location = New System.Drawing.Point(419, 255)
        Me.tab_endereco_escrita_50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_50.Name = "tab_endereco_escrita_50"
        Me.tab_endereco_escrita_50.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_50.TabIndex = 2519
        Me.tab_endereco_escrita_50.Text = "0"
        Me.tab_endereco_escrita_50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_51
        '
        Me.tab_endereco_escrita_51.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_51.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_51.CausesValidation = False
        Me.tab_endereco_escrita_51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_51.Location = New System.Drawing.Point(419, 283)
        Me.tab_endereco_escrita_51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_51.Name = "tab_endereco_escrita_51"
        Me.tab_endereco_escrita_51.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_51.TabIndex = 2519
        Me.tab_endereco_escrita_51.Text = "0"
        Me.tab_endereco_escrita_51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_52
        '
        Me.tab_endereco_escrita_52.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_52.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_52.CausesValidation = False
        Me.tab_endereco_escrita_52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_52.Location = New System.Drawing.Point(419, 311)
        Me.tab_endereco_escrita_52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_52.Name = "tab_endereco_escrita_52"
        Me.tab_endereco_escrita_52.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_52.TabIndex = 2519
        Me.tab_endereco_escrita_52.Text = "0"
        Me.tab_endereco_escrita_52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_53
        '
        Me.tab_endereco_escrita_53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_53.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_53.CausesValidation = False
        Me.tab_endereco_escrita_53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_53.Location = New System.Drawing.Point(419, 339)
        Me.tab_endereco_escrita_53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_53.Name = "tab_endereco_escrita_53"
        Me.tab_endereco_escrita_53.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_53.TabIndex = 2519
        Me.tab_endereco_escrita_53.Text = "0"
        Me.tab_endereco_escrita_53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_54
        '
        Me.tab_endereco_escrita_54.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_54.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_54.CausesValidation = False
        Me.tab_endereco_escrita_54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_54.Location = New System.Drawing.Point(419, 367)
        Me.tab_endereco_escrita_54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_54.Name = "tab_endereco_escrita_54"
        Me.tab_endereco_escrita_54.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_54.TabIndex = 2519
        Me.tab_endereco_escrita_54.Text = "0"
        Me.tab_endereco_escrita_54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_55
        '
        Me.tab_endereco_escrita_55.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_55.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_55.CausesValidation = False
        Me.tab_endereco_escrita_55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_55.Location = New System.Drawing.Point(419, 395)
        Me.tab_endereco_escrita_55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_55.Name = "tab_endereco_escrita_55"
        Me.tab_endereco_escrita_55.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_55.TabIndex = 2519
        Me.tab_endereco_escrita_55.Text = "0"
        Me.tab_endereco_escrita_55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_56
        '
        Me.tab_endereco_escrita_56.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_56.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_56.CausesValidation = False
        Me.tab_endereco_escrita_56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_56.Location = New System.Drawing.Point(419, 423)
        Me.tab_endereco_escrita_56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_56.Name = "tab_endereco_escrita_56"
        Me.tab_endereco_escrita_56.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_56.TabIndex = 2519
        Me.tab_endereco_escrita_56.Text = "0"
        Me.tab_endereco_escrita_56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_57
        '
        Me.tab_endereco_escrita_57.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_57.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_57.CausesValidation = False
        Me.tab_endereco_escrita_57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_57.Location = New System.Drawing.Point(419, 451)
        Me.tab_endereco_escrita_57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_57.Name = "tab_endereco_escrita_57"
        Me.tab_endereco_escrita_57.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_57.TabIndex = 2519
        Me.tab_endereco_escrita_57.Text = "0"
        Me.tab_endereco_escrita_57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_58
        '
        Me.tab_endereco_escrita_58.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_58.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_58.CausesValidation = False
        Me.tab_endereco_escrita_58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_58.Location = New System.Drawing.Point(419, 479)
        Me.tab_endereco_escrita_58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_58.Name = "tab_endereco_escrita_58"
        Me.tab_endereco_escrita_58.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_58.TabIndex = 2519
        Me.tab_endereco_escrita_58.Text = "0"
        Me.tab_endereco_escrita_58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_59
        '
        Me.tab_endereco_escrita_59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_59.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_59.CausesValidation = False
        Me.tab_endereco_escrita_59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_59.Location = New System.Drawing.Point(419, 507)
        Me.tab_endereco_escrita_59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_59.Name = "tab_endereco_escrita_59"
        Me.tab_endereco_escrita_59.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_59.TabIndex = 2519
        Me.tab_endereco_escrita_59.Text = "0"
        Me.tab_endereco_escrita_59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_60
        '
        Me.tab_endereco_escrita_60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_60.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_60.CausesValidation = False
        Me.tab_endereco_escrita_60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_60.Location = New System.Drawing.Point(419, 540)
        Me.tab_endereco_escrita_60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_60.Name = "tab_endereco_escrita_60"
        Me.tab_endereco_escrita_60.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_60.TabIndex = 2519
        Me.tab_endereco_escrita_60.Text = "0"
        Me.tab_endereco_escrita_60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_61
        '
        Me.tab_endereco_escrita_61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_61.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_61.CausesValidation = False
        Me.tab_endereco_escrita_61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_61.Location = New System.Drawing.Point(625, 3)
        Me.tab_endereco_escrita_61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_61.Name = "tab_endereco_escrita_61"
        Me.tab_endereco_escrita_61.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_61.TabIndex = 2519
        Me.tab_endereco_escrita_61.Text = "0"
        Me.tab_endereco_escrita_61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_62
        '
        Me.tab_endereco_escrita_62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_62.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_62.CausesValidation = False
        Me.tab_endereco_escrita_62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_62.Location = New System.Drawing.Point(625, 31)
        Me.tab_endereco_escrita_62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_62.Name = "tab_endereco_escrita_62"
        Me.tab_endereco_escrita_62.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_62.TabIndex = 2519
        Me.tab_endereco_escrita_62.Text = "0"
        Me.tab_endereco_escrita_62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_63
        '
        Me.tab_endereco_escrita_63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_63.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_63.CausesValidation = False
        Me.tab_endereco_escrita_63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_63.Location = New System.Drawing.Point(625, 59)
        Me.tab_endereco_escrita_63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_63.Name = "tab_endereco_escrita_63"
        Me.tab_endereco_escrita_63.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_63.TabIndex = 2519
        Me.tab_endereco_escrita_63.Text = "0"
        Me.tab_endereco_escrita_63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_64
        '
        Me.tab_endereco_escrita_64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_64.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_64.CausesValidation = False
        Me.tab_endereco_escrita_64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_64.Location = New System.Drawing.Point(625, 87)
        Me.tab_endereco_escrita_64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_64.Name = "tab_endereco_escrita_64"
        Me.tab_endereco_escrita_64.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_64.TabIndex = 2519
        Me.tab_endereco_escrita_64.Text = "0"
        Me.tab_endereco_escrita_64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_65
        '
        Me.tab_endereco_escrita_65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_65.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_65.CausesValidation = False
        Me.tab_endereco_escrita_65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_65.Location = New System.Drawing.Point(625, 115)
        Me.tab_endereco_escrita_65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_65.Name = "tab_endereco_escrita_65"
        Me.tab_endereco_escrita_65.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_65.TabIndex = 2519
        Me.tab_endereco_escrita_65.Text = "0"
        Me.tab_endereco_escrita_65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_66
        '
        Me.tab_endereco_escrita_66.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_66.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_66.CausesValidation = False
        Me.tab_endereco_escrita_66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_66.Location = New System.Drawing.Point(625, 143)
        Me.tab_endereco_escrita_66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_66.Name = "tab_endereco_escrita_66"
        Me.tab_endereco_escrita_66.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_66.TabIndex = 2519
        Me.tab_endereco_escrita_66.Text = "0"
        Me.tab_endereco_escrita_66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_67
        '
        Me.tab_endereco_escrita_67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_67.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_67.CausesValidation = False
        Me.tab_endereco_escrita_67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_67.Location = New System.Drawing.Point(625, 171)
        Me.tab_endereco_escrita_67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_67.Name = "tab_endereco_escrita_67"
        Me.tab_endereco_escrita_67.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_67.TabIndex = 2519
        Me.tab_endereco_escrita_67.Text = "0"
        Me.tab_endereco_escrita_67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_68
        '
        Me.tab_endereco_escrita_68.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_68.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_68.CausesValidation = False
        Me.tab_endereco_escrita_68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_68.Location = New System.Drawing.Point(625, 199)
        Me.tab_endereco_escrita_68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_68.Name = "tab_endereco_escrita_68"
        Me.tab_endereco_escrita_68.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_68.TabIndex = 2519
        Me.tab_endereco_escrita_68.Text = "0"
        Me.tab_endereco_escrita_68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_69
        '
        Me.tab_endereco_escrita_69.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_69.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_69.CausesValidation = False
        Me.tab_endereco_escrita_69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_69.Location = New System.Drawing.Point(625, 227)
        Me.tab_endereco_escrita_69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_69.Name = "tab_endereco_escrita_69"
        Me.tab_endereco_escrita_69.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_69.TabIndex = 2519
        Me.tab_endereco_escrita_69.Text = "0"
        Me.tab_endereco_escrita_69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_70
        '
        Me.tab_endereco_escrita_70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_70.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_70.CausesValidation = False
        Me.tab_endereco_escrita_70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_70.Location = New System.Drawing.Point(625, 255)
        Me.tab_endereco_escrita_70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_70.Name = "tab_endereco_escrita_70"
        Me.tab_endereco_escrita_70.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_70.TabIndex = 2519
        Me.tab_endereco_escrita_70.Text = "0"
        Me.tab_endereco_escrita_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_71
        '
        Me.tab_endereco_escrita_71.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_71.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_71.CausesValidation = False
        Me.tab_endereco_escrita_71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_71.Location = New System.Drawing.Point(625, 283)
        Me.tab_endereco_escrita_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_71.Name = "tab_endereco_escrita_71"
        Me.tab_endereco_escrita_71.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_71.TabIndex = 2519
        Me.tab_endereco_escrita_71.Text = "0"
        Me.tab_endereco_escrita_71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_72
        '
        Me.tab_endereco_escrita_72.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_72.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_72.CausesValidation = False
        Me.tab_endereco_escrita_72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_72.Location = New System.Drawing.Point(625, 311)
        Me.tab_endereco_escrita_72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_72.Name = "tab_endereco_escrita_72"
        Me.tab_endereco_escrita_72.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_72.TabIndex = 2519
        Me.tab_endereco_escrita_72.Text = "0"
        Me.tab_endereco_escrita_72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_73
        '
        Me.tab_endereco_escrita_73.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_73.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_73.CausesValidation = False
        Me.tab_endereco_escrita_73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_73.Location = New System.Drawing.Point(625, 339)
        Me.tab_endereco_escrita_73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_73.Name = "tab_endereco_escrita_73"
        Me.tab_endereco_escrita_73.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_73.TabIndex = 2519
        Me.tab_endereco_escrita_73.Text = "0"
        Me.tab_endereco_escrita_73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_74
        '
        Me.tab_endereco_escrita_74.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_74.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_74.CausesValidation = False
        Me.tab_endereco_escrita_74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_74.Location = New System.Drawing.Point(625, 367)
        Me.tab_endereco_escrita_74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_74.Name = "tab_endereco_escrita_74"
        Me.tab_endereco_escrita_74.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_74.TabIndex = 2519
        Me.tab_endereco_escrita_74.Text = "0"
        Me.tab_endereco_escrita_74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_75
        '
        Me.tab_endereco_escrita_75.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_75.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_75.CausesValidation = False
        Me.tab_endereco_escrita_75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_75.Location = New System.Drawing.Point(625, 395)
        Me.tab_endereco_escrita_75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_75.Name = "tab_endereco_escrita_75"
        Me.tab_endereco_escrita_75.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_75.TabIndex = 2519
        Me.tab_endereco_escrita_75.Text = "0"
        Me.tab_endereco_escrita_75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_76
        '
        Me.tab_endereco_escrita_76.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_76.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_76.CausesValidation = False
        Me.tab_endereco_escrita_76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_76.Location = New System.Drawing.Point(625, 423)
        Me.tab_endereco_escrita_76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_76.Name = "tab_endereco_escrita_76"
        Me.tab_endereco_escrita_76.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_76.TabIndex = 2519
        Me.tab_endereco_escrita_76.Text = "0"
        Me.tab_endereco_escrita_76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_77
        '
        Me.tab_endereco_escrita_77.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_77.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_77.CausesValidation = False
        Me.tab_endereco_escrita_77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_77.Location = New System.Drawing.Point(625, 451)
        Me.tab_endereco_escrita_77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_77.Name = "tab_endereco_escrita_77"
        Me.tab_endereco_escrita_77.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_77.TabIndex = 2519
        Me.tab_endereco_escrita_77.Text = "0"
        Me.tab_endereco_escrita_77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_78
        '
        Me.tab_endereco_escrita_78.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_78.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_78.CausesValidation = False
        Me.tab_endereco_escrita_78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_78.Location = New System.Drawing.Point(625, 479)
        Me.tab_endereco_escrita_78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_78.Name = "tab_endereco_escrita_78"
        Me.tab_endereco_escrita_78.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_78.TabIndex = 2519
        Me.tab_endereco_escrita_78.Text = "0"
        Me.tab_endereco_escrita_78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_79
        '
        Me.tab_endereco_escrita_79.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_79.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_79.CausesValidation = False
        Me.tab_endereco_escrita_79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_79.Location = New System.Drawing.Point(625, 507)
        Me.tab_endereco_escrita_79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_79.Name = "tab_endereco_escrita_79"
        Me.tab_endereco_escrita_79.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_79.TabIndex = 2519
        Me.tab_endereco_escrita_79.Text = "0"
        Me.tab_endereco_escrita_79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_80
        '
        Me.tab_endereco_escrita_80.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_80.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_80.CausesValidation = False
        Me.tab_endereco_escrita_80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_80.Location = New System.Drawing.Point(625, 540)
        Me.tab_endereco_escrita_80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_80.Name = "tab_endereco_escrita_80"
        Me.tab_endereco_escrita_80.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_80.TabIndex = 2519
        Me.tab_endereco_escrita_80.Text = "0"
        Me.tab_endereco_escrita_80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_81
        '
        Me.tab_endereco_escrita_81.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_81.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_81.CausesValidation = False
        Me.tab_endereco_escrita_81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_81.Location = New System.Drawing.Point(831, 3)
        Me.tab_endereco_escrita_81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_81.Name = "tab_endereco_escrita_81"
        Me.tab_endereco_escrita_81.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_81.TabIndex = 2519
        Me.tab_endereco_escrita_81.Text = "0"
        Me.tab_endereco_escrita_81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_82
        '
        Me.tab_endereco_escrita_82.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_82.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_82.CausesValidation = False
        Me.tab_endereco_escrita_82.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_82.Location = New System.Drawing.Point(831, 31)
        Me.tab_endereco_escrita_82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_82.Name = "tab_endereco_escrita_82"
        Me.tab_endereco_escrita_82.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_82.TabIndex = 2519
        Me.tab_endereco_escrita_82.Text = "0"
        Me.tab_endereco_escrita_82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_83
        '
        Me.tab_endereco_escrita_83.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_83.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_83.CausesValidation = False
        Me.tab_endereco_escrita_83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_83.Location = New System.Drawing.Point(831, 59)
        Me.tab_endereco_escrita_83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_83.Name = "tab_endereco_escrita_83"
        Me.tab_endereco_escrita_83.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_83.TabIndex = 2519
        Me.tab_endereco_escrita_83.Text = "0"
        Me.tab_endereco_escrita_83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_84
        '
        Me.tab_endereco_escrita_84.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_84.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_84.CausesValidation = False
        Me.tab_endereco_escrita_84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_84.Location = New System.Drawing.Point(831, 87)
        Me.tab_endereco_escrita_84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_84.Name = "tab_endereco_escrita_84"
        Me.tab_endereco_escrita_84.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_84.TabIndex = 2519
        Me.tab_endereco_escrita_84.Text = "0"
        Me.tab_endereco_escrita_84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_85
        '
        Me.tab_endereco_escrita_85.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_85.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_85.CausesValidation = False
        Me.tab_endereco_escrita_85.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_85.Location = New System.Drawing.Point(831, 115)
        Me.tab_endereco_escrita_85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_85.Name = "tab_endereco_escrita_85"
        Me.tab_endereco_escrita_85.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_85.TabIndex = 2519
        Me.tab_endereco_escrita_85.Text = "0"
        Me.tab_endereco_escrita_85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_86
        '
        Me.tab_endereco_escrita_86.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_86.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_86.CausesValidation = False
        Me.tab_endereco_escrita_86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_86.Location = New System.Drawing.Point(831, 143)
        Me.tab_endereco_escrita_86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_86.Name = "tab_endereco_escrita_86"
        Me.tab_endereco_escrita_86.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_86.TabIndex = 2519
        Me.tab_endereco_escrita_86.Text = "0"
        Me.tab_endereco_escrita_86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_87
        '
        Me.tab_endereco_escrita_87.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_87.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_87.CausesValidation = False
        Me.tab_endereco_escrita_87.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_87.Location = New System.Drawing.Point(831, 171)
        Me.tab_endereco_escrita_87.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_87.Name = "tab_endereco_escrita_87"
        Me.tab_endereco_escrita_87.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_87.TabIndex = 2519
        Me.tab_endereco_escrita_87.Text = "0"
        Me.tab_endereco_escrita_87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_88
        '
        Me.tab_endereco_escrita_88.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_88.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_88.CausesValidation = False
        Me.tab_endereco_escrita_88.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_88.Location = New System.Drawing.Point(831, 199)
        Me.tab_endereco_escrita_88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_88.Name = "tab_endereco_escrita_88"
        Me.tab_endereco_escrita_88.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_88.TabIndex = 2519
        Me.tab_endereco_escrita_88.Text = "0"
        Me.tab_endereco_escrita_88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_89
        '
        Me.tab_endereco_escrita_89.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_89.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_89.CausesValidation = False
        Me.tab_endereco_escrita_89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_89.Location = New System.Drawing.Point(831, 227)
        Me.tab_endereco_escrita_89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_89.Name = "tab_endereco_escrita_89"
        Me.tab_endereco_escrita_89.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_89.TabIndex = 2519
        Me.tab_endereco_escrita_89.Text = "0"
        Me.tab_endereco_escrita_89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_90
        '
        Me.tab_endereco_escrita_90.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_90.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_90.CausesValidation = False
        Me.tab_endereco_escrita_90.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_90.Location = New System.Drawing.Point(831, 255)
        Me.tab_endereco_escrita_90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_90.Name = "tab_endereco_escrita_90"
        Me.tab_endereco_escrita_90.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_90.TabIndex = 2519
        Me.tab_endereco_escrita_90.Text = "0"
        Me.tab_endereco_escrita_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_91
        '
        Me.tab_endereco_escrita_91.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_91.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_91.CausesValidation = False
        Me.tab_endereco_escrita_91.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_91.Location = New System.Drawing.Point(831, 283)
        Me.tab_endereco_escrita_91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_91.Name = "tab_endereco_escrita_91"
        Me.tab_endereco_escrita_91.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_91.TabIndex = 2519
        Me.tab_endereco_escrita_91.Text = "0"
        Me.tab_endereco_escrita_91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_92
        '
        Me.tab_endereco_escrita_92.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_92.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_92.CausesValidation = False
        Me.tab_endereco_escrita_92.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_92.Location = New System.Drawing.Point(831, 311)
        Me.tab_endereco_escrita_92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_92.Name = "tab_endereco_escrita_92"
        Me.tab_endereco_escrita_92.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_92.TabIndex = 2519
        Me.tab_endereco_escrita_92.Text = "0"
        Me.tab_endereco_escrita_92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_93
        '
        Me.tab_endereco_escrita_93.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_93.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_93.CausesValidation = False
        Me.tab_endereco_escrita_93.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_93.Location = New System.Drawing.Point(831, 339)
        Me.tab_endereco_escrita_93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_93.Name = "tab_endereco_escrita_93"
        Me.tab_endereco_escrita_93.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_93.TabIndex = 2519
        Me.tab_endereco_escrita_93.Text = "0"
        Me.tab_endereco_escrita_93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_94
        '
        Me.tab_endereco_escrita_94.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_94.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_94.CausesValidation = False
        Me.tab_endereco_escrita_94.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_94.Location = New System.Drawing.Point(831, 367)
        Me.tab_endereco_escrita_94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_94.Name = "tab_endereco_escrita_94"
        Me.tab_endereco_escrita_94.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_94.TabIndex = 2519
        Me.tab_endereco_escrita_94.Text = "0"
        Me.tab_endereco_escrita_94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_95
        '
        Me.tab_endereco_escrita_95.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_95.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_95.CausesValidation = False
        Me.tab_endereco_escrita_95.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_95.Location = New System.Drawing.Point(831, 395)
        Me.tab_endereco_escrita_95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_95.Name = "tab_endereco_escrita_95"
        Me.tab_endereco_escrita_95.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_95.TabIndex = 2519
        Me.tab_endereco_escrita_95.Text = "0"
        Me.tab_endereco_escrita_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_96
        '
        Me.tab_endereco_escrita_96.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_96.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_96.CausesValidation = False
        Me.tab_endereco_escrita_96.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_96.Location = New System.Drawing.Point(831, 423)
        Me.tab_endereco_escrita_96.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_96.Name = "tab_endereco_escrita_96"
        Me.tab_endereco_escrita_96.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_96.TabIndex = 2519
        Me.tab_endereco_escrita_96.Text = "0"
        Me.tab_endereco_escrita_96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_97
        '
        Me.tab_endereco_escrita_97.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_97.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_97.CausesValidation = False
        Me.tab_endereco_escrita_97.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_97.Location = New System.Drawing.Point(831, 451)
        Me.tab_endereco_escrita_97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_97.Name = "tab_endereco_escrita_97"
        Me.tab_endereco_escrita_97.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_97.TabIndex = 2519
        Me.tab_endereco_escrita_97.Text = "0"
        Me.tab_endereco_escrita_97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_98
        '
        Me.tab_endereco_escrita_98.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_98.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_98.CausesValidation = False
        Me.tab_endereco_escrita_98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_98.Location = New System.Drawing.Point(831, 479)
        Me.tab_endereco_escrita_98.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_98.Name = "tab_endereco_escrita_98"
        Me.tab_endereco_escrita_98.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_98.TabIndex = 2519
        Me.tab_endereco_escrita_98.Text = "0"
        Me.tab_endereco_escrita_98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_99
        '
        Me.tab_endereco_escrita_99.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_99.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_99.CausesValidation = False
        Me.tab_endereco_escrita_99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_99.Location = New System.Drawing.Point(831, 507)
        Me.tab_endereco_escrita_99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_99.Name = "tab_endereco_escrita_99"
        Me.tab_endereco_escrita_99.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_99.TabIndex = 2519
        Me.tab_endereco_escrita_99.Text = "0"
        Me.tab_endereco_escrita_99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_endereco_escrita_100
        '
        Me.tab_endereco_escrita_100.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_endereco_escrita_100.BackColor = System.Drawing.Color.White
        Me.tab_endereco_escrita_100.CausesValidation = False
        Me.tab_endereco_escrita_100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tab_endereco_escrita_100.Location = New System.Drawing.Point(831, 540)
        Me.tab_endereco_escrita_100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_endereco_escrita_100.Name = "tab_endereco_escrita_100"
        Me.tab_endereco_escrita_100.Size = New System.Drawing.Size(59, 25)
        Me.tab_endereco_escrita_100.TabIndex = 2519
        Me.tab_endereco_escrita_100.Text = "0"
        Me.tab_endereco_escrita_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_1
        '
        Me.tab_valor_escrita_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_1.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_1.CausesValidation = False
        Me.tab_valor_escrita_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_1.Location = New System.Drawing.Point(77, 3)
        Me.tab_valor_escrita_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_1.Name = "tab_valor_escrita_1"
        Me.tab_valor_escrita_1.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_1.TabIndex = 2519
        Me.tab_valor_escrita_1.Text = "0"
        Me.tab_valor_escrita_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_2
        '
        Me.tab_valor_escrita_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_2.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_2.CausesValidation = False
        Me.tab_valor_escrita_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_2.Location = New System.Drawing.Point(77, 31)
        Me.tab_valor_escrita_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_2.Name = "tab_valor_escrita_2"
        Me.tab_valor_escrita_2.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_2.TabIndex = 2519
        Me.tab_valor_escrita_2.Text = "0"
        Me.tab_valor_escrita_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_3
        '
        Me.tab_valor_escrita_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_3.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_3.CausesValidation = False
        Me.tab_valor_escrita_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_3.Location = New System.Drawing.Point(77, 59)
        Me.tab_valor_escrita_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_3.Name = "tab_valor_escrita_3"
        Me.tab_valor_escrita_3.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_3.TabIndex = 2519
        Me.tab_valor_escrita_3.Text = "0"
        Me.tab_valor_escrita_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_4
        '
        Me.tab_valor_escrita_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_4.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_4.CausesValidation = False
        Me.tab_valor_escrita_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_4.Location = New System.Drawing.Point(77, 87)
        Me.tab_valor_escrita_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_4.Name = "tab_valor_escrita_4"
        Me.tab_valor_escrita_4.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_4.TabIndex = 2519
        Me.tab_valor_escrita_4.Text = "0"
        Me.tab_valor_escrita_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_5
        '
        Me.tab_valor_escrita_5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_5.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_5.CausesValidation = False
        Me.tab_valor_escrita_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_5.Location = New System.Drawing.Point(77, 115)
        Me.tab_valor_escrita_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_5.Name = "tab_valor_escrita_5"
        Me.tab_valor_escrita_5.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_5.TabIndex = 2519
        Me.tab_valor_escrita_5.Text = "0"
        Me.tab_valor_escrita_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_6
        '
        Me.tab_valor_escrita_6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_6.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_6.CausesValidation = False
        Me.tab_valor_escrita_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_6.Location = New System.Drawing.Point(77, 143)
        Me.tab_valor_escrita_6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_6.Name = "tab_valor_escrita_6"
        Me.tab_valor_escrita_6.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_6.TabIndex = 2519
        Me.tab_valor_escrita_6.Text = "0"
        Me.tab_valor_escrita_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_7
        '
        Me.tab_valor_escrita_7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_7.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_7.CausesValidation = False
        Me.tab_valor_escrita_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_7.Location = New System.Drawing.Point(77, 171)
        Me.tab_valor_escrita_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_7.Name = "tab_valor_escrita_7"
        Me.tab_valor_escrita_7.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_7.TabIndex = 2519
        Me.tab_valor_escrita_7.Text = "0"
        Me.tab_valor_escrita_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_8
        '
        Me.tab_valor_escrita_8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_8.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_8.CausesValidation = False
        Me.tab_valor_escrita_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_8.Location = New System.Drawing.Point(77, 199)
        Me.tab_valor_escrita_8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_8.Name = "tab_valor_escrita_8"
        Me.tab_valor_escrita_8.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_8.TabIndex = 2519
        Me.tab_valor_escrita_8.Text = "0"
        Me.tab_valor_escrita_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_9
        '
        Me.tab_valor_escrita_9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_9.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_9.CausesValidation = False
        Me.tab_valor_escrita_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_9.Location = New System.Drawing.Point(77, 227)
        Me.tab_valor_escrita_9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_9.Name = "tab_valor_escrita_9"
        Me.tab_valor_escrita_9.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_9.TabIndex = 2519
        Me.tab_valor_escrita_9.Text = "0"
        Me.tab_valor_escrita_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_10
        '
        Me.tab_valor_escrita_10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_10.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_10.CausesValidation = False
        Me.tab_valor_escrita_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_10.Location = New System.Drawing.Point(77, 255)
        Me.tab_valor_escrita_10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_10.Name = "tab_valor_escrita_10"
        Me.tab_valor_escrita_10.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_10.TabIndex = 2519
        Me.tab_valor_escrita_10.Text = "0"
        Me.tab_valor_escrita_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_11
        '
        Me.tab_valor_escrita_11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_11.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_11.CausesValidation = False
        Me.tab_valor_escrita_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_11.Location = New System.Drawing.Point(77, 283)
        Me.tab_valor_escrita_11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_11.Name = "tab_valor_escrita_11"
        Me.tab_valor_escrita_11.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_11.TabIndex = 2519
        Me.tab_valor_escrita_11.Text = "0"
        Me.tab_valor_escrita_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_12
        '
        Me.tab_valor_escrita_12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_12.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_12.CausesValidation = False
        Me.tab_valor_escrita_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_12.Location = New System.Drawing.Point(77, 311)
        Me.tab_valor_escrita_12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_12.Name = "tab_valor_escrita_12"
        Me.tab_valor_escrita_12.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_12.TabIndex = 2519
        Me.tab_valor_escrita_12.Text = "0"
        Me.tab_valor_escrita_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_13
        '
        Me.tab_valor_escrita_13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_13.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_13.CausesValidation = False
        Me.tab_valor_escrita_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_13.Location = New System.Drawing.Point(77, 339)
        Me.tab_valor_escrita_13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_13.Name = "tab_valor_escrita_13"
        Me.tab_valor_escrita_13.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_13.TabIndex = 2519
        Me.tab_valor_escrita_13.Text = "0"
        Me.tab_valor_escrita_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_14
        '
        Me.tab_valor_escrita_14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_14.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_14.CausesValidation = False
        Me.tab_valor_escrita_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_14.Location = New System.Drawing.Point(77, 367)
        Me.tab_valor_escrita_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_14.Name = "tab_valor_escrita_14"
        Me.tab_valor_escrita_14.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_14.TabIndex = 2519
        Me.tab_valor_escrita_14.Text = "0"
        Me.tab_valor_escrita_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_15
        '
        Me.tab_valor_escrita_15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_15.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_15.CausesValidation = False
        Me.tab_valor_escrita_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_15.Location = New System.Drawing.Point(77, 395)
        Me.tab_valor_escrita_15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_15.Name = "tab_valor_escrita_15"
        Me.tab_valor_escrita_15.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_15.TabIndex = 2519
        Me.tab_valor_escrita_15.Text = "0"
        Me.tab_valor_escrita_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_16
        '
        Me.tab_valor_escrita_16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_16.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_16.CausesValidation = False
        Me.tab_valor_escrita_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_16.Location = New System.Drawing.Point(77, 423)
        Me.tab_valor_escrita_16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_16.Name = "tab_valor_escrita_16"
        Me.tab_valor_escrita_16.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_16.TabIndex = 2519
        Me.tab_valor_escrita_16.Text = "0"
        Me.tab_valor_escrita_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_17
        '
        Me.tab_valor_escrita_17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_17.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_17.CausesValidation = False
        Me.tab_valor_escrita_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_17.Location = New System.Drawing.Point(77, 451)
        Me.tab_valor_escrita_17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_17.Name = "tab_valor_escrita_17"
        Me.tab_valor_escrita_17.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_17.TabIndex = 2519
        Me.tab_valor_escrita_17.Text = "0"
        Me.tab_valor_escrita_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_18
        '
        Me.tab_valor_escrita_18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_18.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_18.CausesValidation = False
        Me.tab_valor_escrita_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_18.Location = New System.Drawing.Point(77, 479)
        Me.tab_valor_escrita_18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_18.Name = "tab_valor_escrita_18"
        Me.tab_valor_escrita_18.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_18.TabIndex = 2519
        Me.tab_valor_escrita_18.Text = "0"
        Me.tab_valor_escrita_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_19
        '
        Me.tab_valor_escrita_19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_19.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_19.CausesValidation = False
        Me.tab_valor_escrita_19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_19.Location = New System.Drawing.Point(77, 507)
        Me.tab_valor_escrita_19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_19.Name = "tab_valor_escrita_19"
        Me.tab_valor_escrita_19.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_19.TabIndex = 2519
        Me.tab_valor_escrita_19.Text = "0"
        Me.tab_valor_escrita_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_20
        '
        Me.tab_valor_escrita_20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_20.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_20.CausesValidation = False
        Me.tab_valor_escrita_20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_20.Location = New System.Drawing.Point(77, 540)
        Me.tab_valor_escrita_20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_20.Name = "tab_valor_escrita_20"
        Me.tab_valor_escrita_20.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_20.TabIndex = 2519
        Me.tab_valor_escrita_20.Text = "0"
        Me.tab_valor_escrita_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_21
        '
        Me.tab_valor_escrita_21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_21.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_21.CausesValidation = False
        Me.tab_valor_escrita_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_21.Location = New System.Drawing.Point(283, 3)
        Me.tab_valor_escrita_21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_21.Name = "tab_valor_escrita_21"
        Me.tab_valor_escrita_21.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_21.TabIndex = 2519
        Me.tab_valor_escrita_21.Text = "0"
        Me.tab_valor_escrita_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_22
        '
        Me.tab_valor_escrita_22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_22.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_22.CausesValidation = False
        Me.tab_valor_escrita_22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_22.Location = New System.Drawing.Point(283, 31)
        Me.tab_valor_escrita_22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_22.Name = "tab_valor_escrita_22"
        Me.tab_valor_escrita_22.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_22.TabIndex = 2519
        Me.tab_valor_escrita_22.Text = "0"
        Me.tab_valor_escrita_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_23
        '
        Me.tab_valor_escrita_23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_23.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_23.CausesValidation = False
        Me.tab_valor_escrita_23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_23.Location = New System.Drawing.Point(283, 59)
        Me.tab_valor_escrita_23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_23.Name = "tab_valor_escrita_23"
        Me.tab_valor_escrita_23.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_23.TabIndex = 2519
        Me.tab_valor_escrita_23.Text = "0"
        Me.tab_valor_escrita_23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_24
        '
        Me.tab_valor_escrita_24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_24.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_24.CausesValidation = False
        Me.tab_valor_escrita_24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_24.Location = New System.Drawing.Point(283, 87)
        Me.tab_valor_escrita_24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_24.Name = "tab_valor_escrita_24"
        Me.tab_valor_escrita_24.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_24.TabIndex = 2519
        Me.tab_valor_escrita_24.Text = "0"
        Me.tab_valor_escrita_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_25
        '
        Me.tab_valor_escrita_25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_25.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_25.CausesValidation = False
        Me.tab_valor_escrita_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_25.Location = New System.Drawing.Point(283, 115)
        Me.tab_valor_escrita_25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_25.Name = "tab_valor_escrita_25"
        Me.tab_valor_escrita_25.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_25.TabIndex = 2519
        Me.tab_valor_escrita_25.Text = "0"
        Me.tab_valor_escrita_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_26
        '
        Me.tab_valor_escrita_26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_26.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_26.CausesValidation = False
        Me.tab_valor_escrita_26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_26.Location = New System.Drawing.Point(283, 143)
        Me.tab_valor_escrita_26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_26.Name = "tab_valor_escrita_26"
        Me.tab_valor_escrita_26.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_26.TabIndex = 2519
        Me.tab_valor_escrita_26.Text = "0"
        Me.tab_valor_escrita_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_27
        '
        Me.tab_valor_escrita_27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_27.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_27.CausesValidation = False
        Me.tab_valor_escrita_27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_27.Location = New System.Drawing.Point(283, 171)
        Me.tab_valor_escrita_27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_27.Name = "tab_valor_escrita_27"
        Me.tab_valor_escrita_27.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_27.TabIndex = 2519
        Me.tab_valor_escrita_27.Text = "0"
        Me.tab_valor_escrita_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_28
        '
        Me.tab_valor_escrita_28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_28.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_28.CausesValidation = False
        Me.tab_valor_escrita_28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_28.Location = New System.Drawing.Point(283, 199)
        Me.tab_valor_escrita_28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_28.Name = "tab_valor_escrita_28"
        Me.tab_valor_escrita_28.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_28.TabIndex = 2519
        Me.tab_valor_escrita_28.Text = "0"
        Me.tab_valor_escrita_28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_29
        '
        Me.tab_valor_escrita_29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_29.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_29.CausesValidation = False
        Me.tab_valor_escrita_29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_29.Location = New System.Drawing.Point(283, 227)
        Me.tab_valor_escrita_29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_29.Name = "tab_valor_escrita_29"
        Me.tab_valor_escrita_29.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_29.TabIndex = 2519
        Me.tab_valor_escrita_29.Text = "0"
        Me.tab_valor_escrita_29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_30
        '
        Me.tab_valor_escrita_30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_30.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_30.CausesValidation = False
        Me.tab_valor_escrita_30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_30.Location = New System.Drawing.Point(283, 255)
        Me.tab_valor_escrita_30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_30.Name = "tab_valor_escrita_30"
        Me.tab_valor_escrita_30.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_30.TabIndex = 2519
        Me.tab_valor_escrita_30.Text = "0"
        Me.tab_valor_escrita_30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_31
        '
        Me.tab_valor_escrita_31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_31.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_31.CausesValidation = False
        Me.tab_valor_escrita_31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_31.Location = New System.Drawing.Point(283, 283)
        Me.tab_valor_escrita_31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_31.Name = "tab_valor_escrita_31"
        Me.tab_valor_escrita_31.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_31.TabIndex = 2519
        Me.tab_valor_escrita_31.Text = "0"
        Me.tab_valor_escrita_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_32
        '
        Me.tab_valor_escrita_32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_32.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_32.CausesValidation = False
        Me.tab_valor_escrita_32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_32.Location = New System.Drawing.Point(283, 311)
        Me.tab_valor_escrita_32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_32.Name = "tab_valor_escrita_32"
        Me.tab_valor_escrita_32.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_32.TabIndex = 2519
        Me.tab_valor_escrita_32.Text = "0"
        Me.tab_valor_escrita_32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_33
        '
        Me.tab_valor_escrita_33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_33.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_33.CausesValidation = False
        Me.tab_valor_escrita_33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_33.Location = New System.Drawing.Point(283, 339)
        Me.tab_valor_escrita_33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_33.Name = "tab_valor_escrita_33"
        Me.tab_valor_escrita_33.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_33.TabIndex = 2519
        Me.tab_valor_escrita_33.Text = "0"
        Me.tab_valor_escrita_33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_34
        '
        Me.tab_valor_escrita_34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_34.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_34.CausesValidation = False
        Me.tab_valor_escrita_34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_34.Location = New System.Drawing.Point(283, 367)
        Me.tab_valor_escrita_34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_34.Name = "tab_valor_escrita_34"
        Me.tab_valor_escrita_34.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_34.TabIndex = 2519
        Me.tab_valor_escrita_34.Text = "0"
        Me.tab_valor_escrita_34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_35
        '
        Me.tab_valor_escrita_35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_35.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_35.CausesValidation = False
        Me.tab_valor_escrita_35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_35.Location = New System.Drawing.Point(283, 395)
        Me.tab_valor_escrita_35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_35.Name = "tab_valor_escrita_35"
        Me.tab_valor_escrita_35.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_35.TabIndex = 2519
        Me.tab_valor_escrita_35.Text = "0"
        Me.tab_valor_escrita_35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_36
        '
        Me.tab_valor_escrita_36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_36.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_36.CausesValidation = False
        Me.tab_valor_escrita_36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_36.Location = New System.Drawing.Point(283, 423)
        Me.tab_valor_escrita_36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_36.Name = "tab_valor_escrita_36"
        Me.tab_valor_escrita_36.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_36.TabIndex = 2519
        Me.tab_valor_escrita_36.Text = "0"
        Me.tab_valor_escrita_36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_37
        '
        Me.tab_valor_escrita_37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_37.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_37.CausesValidation = False
        Me.tab_valor_escrita_37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_37.Location = New System.Drawing.Point(283, 451)
        Me.tab_valor_escrita_37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_37.Name = "tab_valor_escrita_37"
        Me.tab_valor_escrita_37.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_37.TabIndex = 2519
        Me.tab_valor_escrita_37.Text = "0"
        Me.tab_valor_escrita_37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_38
        '
        Me.tab_valor_escrita_38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_38.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_38.CausesValidation = False
        Me.tab_valor_escrita_38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_38.Location = New System.Drawing.Point(283, 479)
        Me.tab_valor_escrita_38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_38.Name = "tab_valor_escrita_38"
        Me.tab_valor_escrita_38.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_38.TabIndex = 2519
        Me.tab_valor_escrita_38.Text = "0"
        Me.tab_valor_escrita_38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_39
        '
        Me.tab_valor_escrita_39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_39.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_39.CausesValidation = False
        Me.tab_valor_escrita_39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_39.Location = New System.Drawing.Point(283, 507)
        Me.tab_valor_escrita_39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_39.Name = "tab_valor_escrita_39"
        Me.tab_valor_escrita_39.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_39.TabIndex = 2519
        Me.tab_valor_escrita_39.Text = "0"
        Me.tab_valor_escrita_39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_40
        '
        Me.tab_valor_escrita_40.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_40.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_40.CausesValidation = False
        Me.tab_valor_escrita_40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_40.Location = New System.Drawing.Point(283, 540)
        Me.tab_valor_escrita_40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_40.Name = "tab_valor_escrita_40"
        Me.tab_valor_escrita_40.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_40.TabIndex = 2519
        Me.tab_valor_escrita_40.Text = "0"
        Me.tab_valor_escrita_40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_41
        '
        Me.tab_valor_escrita_41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_41.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_41.CausesValidation = False
        Me.tab_valor_escrita_41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_41.Location = New System.Drawing.Point(489, 3)
        Me.tab_valor_escrita_41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_41.Name = "tab_valor_escrita_41"
        Me.tab_valor_escrita_41.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_41.TabIndex = 2519
        Me.tab_valor_escrita_41.Text = "0"
        Me.tab_valor_escrita_41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_42
        '
        Me.tab_valor_escrita_42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_42.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_42.CausesValidation = False
        Me.tab_valor_escrita_42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_42.Location = New System.Drawing.Point(489, 31)
        Me.tab_valor_escrita_42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_42.Name = "tab_valor_escrita_42"
        Me.tab_valor_escrita_42.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_42.TabIndex = 2519
        Me.tab_valor_escrita_42.Text = "0"
        Me.tab_valor_escrita_42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_43
        '
        Me.tab_valor_escrita_43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_43.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_43.CausesValidation = False
        Me.tab_valor_escrita_43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_43.Location = New System.Drawing.Point(489, 59)
        Me.tab_valor_escrita_43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_43.Name = "tab_valor_escrita_43"
        Me.tab_valor_escrita_43.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_43.TabIndex = 2519
        Me.tab_valor_escrita_43.Text = "0"
        Me.tab_valor_escrita_43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_44
        '
        Me.tab_valor_escrita_44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_44.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_44.CausesValidation = False
        Me.tab_valor_escrita_44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_44.Location = New System.Drawing.Point(489, 87)
        Me.tab_valor_escrita_44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_44.Name = "tab_valor_escrita_44"
        Me.tab_valor_escrita_44.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_44.TabIndex = 2519
        Me.tab_valor_escrita_44.Text = "0"
        Me.tab_valor_escrita_44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_45
        '
        Me.tab_valor_escrita_45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_45.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_45.CausesValidation = False
        Me.tab_valor_escrita_45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_45.Location = New System.Drawing.Point(489, 115)
        Me.tab_valor_escrita_45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_45.Name = "tab_valor_escrita_45"
        Me.tab_valor_escrita_45.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_45.TabIndex = 2519
        Me.tab_valor_escrita_45.Text = "0"
        Me.tab_valor_escrita_45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_46
        '
        Me.tab_valor_escrita_46.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_46.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_46.CausesValidation = False
        Me.tab_valor_escrita_46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_46.Location = New System.Drawing.Point(489, 143)
        Me.tab_valor_escrita_46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_46.Name = "tab_valor_escrita_46"
        Me.tab_valor_escrita_46.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_46.TabIndex = 2519
        Me.tab_valor_escrita_46.Text = "0"
        Me.tab_valor_escrita_46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_47
        '
        Me.tab_valor_escrita_47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_47.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_47.CausesValidation = False
        Me.tab_valor_escrita_47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_47.Location = New System.Drawing.Point(489, 171)
        Me.tab_valor_escrita_47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_47.Name = "tab_valor_escrita_47"
        Me.tab_valor_escrita_47.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_47.TabIndex = 2519
        Me.tab_valor_escrita_47.Text = "0"
        Me.tab_valor_escrita_47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_48
        '
        Me.tab_valor_escrita_48.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_48.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_48.CausesValidation = False
        Me.tab_valor_escrita_48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_48.Location = New System.Drawing.Point(489, 199)
        Me.tab_valor_escrita_48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_48.Name = "tab_valor_escrita_48"
        Me.tab_valor_escrita_48.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_48.TabIndex = 2519
        Me.tab_valor_escrita_48.Text = "0"
        Me.tab_valor_escrita_48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_49
        '
        Me.tab_valor_escrita_49.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_49.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_49.CausesValidation = False
        Me.tab_valor_escrita_49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_49.Location = New System.Drawing.Point(489, 227)
        Me.tab_valor_escrita_49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_49.Name = "tab_valor_escrita_49"
        Me.tab_valor_escrita_49.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_49.TabIndex = 2519
        Me.tab_valor_escrita_49.Text = "0"
        Me.tab_valor_escrita_49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_50
        '
        Me.tab_valor_escrita_50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_50.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_50.CausesValidation = False
        Me.tab_valor_escrita_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_50.Location = New System.Drawing.Point(489, 255)
        Me.tab_valor_escrita_50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_50.Name = "tab_valor_escrita_50"
        Me.tab_valor_escrita_50.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_50.TabIndex = 2519
        Me.tab_valor_escrita_50.Text = "0"
        Me.tab_valor_escrita_50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_51
        '
        Me.tab_valor_escrita_51.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_51.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_51.CausesValidation = False
        Me.tab_valor_escrita_51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_51.Location = New System.Drawing.Point(489, 283)
        Me.tab_valor_escrita_51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_51.Name = "tab_valor_escrita_51"
        Me.tab_valor_escrita_51.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_51.TabIndex = 2519
        Me.tab_valor_escrita_51.Text = "0"
        Me.tab_valor_escrita_51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_52
        '
        Me.tab_valor_escrita_52.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_52.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_52.CausesValidation = False
        Me.tab_valor_escrita_52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_52.Location = New System.Drawing.Point(489, 311)
        Me.tab_valor_escrita_52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_52.Name = "tab_valor_escrita_52"
        Me.tab_valor_escrita_52.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_52.TabIndex = 2519
        Me.tab_valor_escrita_52.Text = "0"
        Me.tab_valor_escrita_52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_53
        '
        Me.tab_valor_escrita_53.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_53.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_53.CausesValidation = False
        Me.tab_valor_escrita_53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_53.Location = New System.Drawing.Point(489, 339)
        Me.tab_valor_escrita_53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_53.Name = "tab_valor_escrita_53"
        Me.tab_valor_escrita_53.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_53.TabIndex = 2519
        Me.tab_valor_escrita_53.Text = "0"
        Me.tab_valor_escrita_53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_54
        '
        Me.tab_valor_escrita_54.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_54.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_54.CausesValidation = False
        Me.tab_valor_escrita_54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_54.Location = New System.Drawing.Point(489, 367)
        Me.tab_valor_escrita_54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_54.Name = "tab_valor_escrita_54"
        Me.tab_valor_escrita_54.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_54.TabIndex = 2519
        Me.tab_valor_escrita_54.Text = "0"
        Me.tab_valor_escrita_54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_55
        '
        Me.tab_valor_escrita_55.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_55.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_55.CausesValidation = False
        Me.tab_valor_escrita_55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_55.Location = New System.Drawing.Point(489, 395)
        Me.tab_valor_escrita_55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_55.Name = "tab_valor_escrita_55"
        Me.tab_valor_escrita_55.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_55.TabIndex = 2519
        Me.tab_valor_escrita_55.Text = "0"
        Me.tab_valor_escrita_55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_56
        '
        Me.tab_valor_escrita_56.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_56.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_56.CausesValidation = False
        Me.tab_valor_escrita_56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_56.Location = New System.Drawing.Point(489, 423)
        Me.tab_valor_escrita_56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_56.Name = "tab_valor_escrita_56"
        Me.tab_valor_escrita_56.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_56.TabIndex = 2519
        Me.tab_valor_escrita_56.Text = "0"
        Me.tab_valor_escrita_56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_57
        '
        Me.tab_valor_escrita_57.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_57.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_57.CausesValidation = False
        Me.tab_valor_escrita_57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_57.Location = New System.Drawing.Point(489, 451)
        Me.tab_valor_escrita_57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_57.Name = "tab_valor_escrita_57"
        Me.tab_valor_escrita_57.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_57.TabIndex = 2519
        Me.tab_valor_escrita_57.Text = "0"
        Me.tab_valor_escrita_57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_58
        '
        Me.tab_valor_escrita_58.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_58.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_58.CausesValidation = False
        Me.tab_valor_escrita_58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_58.Location = New System.Drawing.Point(489, 479)
        Me.tab_valor_escrita_58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_58.Name = "tab_valor_escrita_58"
        Me.tab_valor_escrita_58.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_58.TabIndex = 2519
        Me.tab_valor_escrita_58.Text = "0"
        Me.tab_valor_escrita_58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_59
        '
        Me.tab_valor_escrita_59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_59.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_59.CausesValidation = False
        Me.tab_valor_escrita_59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_59.Location = New System.Drawing.Point(489, 507)
        Me.tab_valor_escrita_59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_59.Name = "tab_valor_escrita_59"
        Me.tab_valor_escrita_59.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_59.TabIndex = 2519
        Me.tab_valor_escrita_59.Text = "0"
        Me.tab_valor_escrita_59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_60
        '
        Me.tab_valor_escrita_60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_60.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_60.CausesValidation = False
        Me.tab_valor_escrita_60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_60.Location = New System.Drawing.Point(489, 540)
        Me.tab_valor_escrita_60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_60.Name = "tab_valor_escrita_60"
        Me.tab_valor_escrita_60.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_60.TabIndex = 2519
        Me.tab_valor_escrita_60.Text = "0"
        Me.tab_valor_escrita_60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_61
        '
        Me.tab_valor_escrita_61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_61.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_61.CausesValidation = False
        Me.tab_valor_escrita_61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_61.Location = New System.Drawing.Point(695, 3)
        Me.tab_valor_escrita_61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_61.Name = "tab_valor_escrita_61"
        Me.tab_valor_escrita_61.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_61.TabIndex = 2519
        Me.tab_valor_escrita_61.Text = "0"
        Me.tab_valor_escrita_61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_62
        '
        Me.tab_valor_escrita_62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_62.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_62.CausesValidation = False
        Me.tab_valor_escrita_62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_62.Location = New System.Drawing.Point(695, 31)
        Me.tab_valor_escrita_62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_62.Name = "tab_valor_escrita_62"
        Me.tab_valor_escrita_62.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_62.TabIndex = 2519
        Me.tab_valor_escrita_62.Text = "0"
        Me.tab_valor_escrita_62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_63
        '
        Me.tab_valor_escrita_63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_63.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_63.CausesValidation = False
        Me.tab_valor_escrita_63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_63.Location = New System.Drawing.Point(695, 59)
        Me.tab_valor_escrita_63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_63.Name = "tab_valor_escrita_63"
        Me.tab_valor_escrita_63.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_63.TabIndex = 2519
        Me.tab_valor_escrita_63.Text = "0"
        Me.tab_valor_escrita_63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_64
        '
        Me.tab_valor_escrita_64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_64.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_64.CausesValidation = False
        Me.tab_valor_escrita_64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_64.Location = New System.Drawing.Point(695, 87)
        Me.tab_valor_escrita_64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_64.Name = "tab_valor_escrita_64"
        Me.tab_valor_escrita_64.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_64.TabIndex = 2519
        Me.tab_valor_escrita_64.Text = "0"
        Me.tab_valor_escrita_64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_65
        '
        Me.tab_valor_escrita_65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_65.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_65.CausesValidation = False
        Me.tab_valor_escrita_65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_65.Location = New System.Drawing.Point(695, 115)
        Me.tab_valor_escrita_65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_65.Name = "tab_valor_escrita_65"
        Me.tab_valor_escrita_65.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_65.TabIndex = 2519
        Me.tab_valor_escrita_65.Text = "0"
        Me.tab_valor_escrita_65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_66
        '
        Me.tab_valor_escrita_66.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_66.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_66.CausesValidation = False
        Me.tab_valor_escrita_66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_66.Location = New System.Drawing.Point(695, 143)
        Me.tab_valor_escrita_66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_66.Name = "tab_valor_escrita_66"
        Me.tab_valor_escrita_66.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_66.TabIndex = 2519
        Me.tab_valor_escrita_66.Text = "0"
        Me.tab_valor_escrita_66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_67
        '
        Me.tab_valor_escrita_67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_67.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_67.CausesValidation = False
        Me.tab_valor_escrita_67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_67.Location = New System.Drawing.Point(695, 171)
        Me.tab_valor_escrita_67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_67.Name = "tab_valor_escrita_67"
        Me.tab_valor_escrita_67.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_67.TabIndex = 2519
        Me.tab_valor_escrita_67.Text = "0"
        Me.tab_valor_escrita_67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_68
        '
        Me.tab_valor_escrita_68.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_68.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_68.CausesValidation = False
        Me.tab_valor_escrita_68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_68.Location = New System.Drawing.Point(695, 199)
        Me.tab_valor_escrita_68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_68.Name = "tab_valor_escrita_68"
        Me.tab_valor_escrita_68.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_68.TabIndex = 2519
        Me.tab_valor_escrita_68.Text = "0"
        Me.tab_valor_escrita_68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_69
        '
        Me.tab_valor_escrita_69.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_69.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_69.CausesValidation = False
        Me.tab_valor_escrita_69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_69.Location = New System.Drawing.Point(695, 227)
        Me.tab_valor_escrita_69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_69.Name = "tab_valor_escrita_69"
        Me.tab_valor_escrita_69.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_69.TabIndex = 2519
        Me.tab_valor_escrita_69.Text = "0"
        Me.tab_valor_escrita_69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_70
        '
        Me.tab_valor_escrita_70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_70.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_70.CausesValidation = False
        Me.tab_valor_escrita_70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_70.Location = New System.Drawing.Point(695, 255)
        Me.tab_valor_escrita_70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_70.Name = "tab_valor_escrita_70"
        Me.tab_valor_escrita_70.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_70.TabIndex = 2519
        Me.tab_valor_escrita_70.Text = "0"
        Me.tab_valor_escrita_70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_71
        '
        Me.tab_valor_escrita_71.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_71.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_71.CausesValidation = False
        Me.tab_valor_escrita_71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_71.Location = New System.Drawing.Point(695, 283)
        Me.tab_valor_escrita_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_71.Name = "tab_valor_escrita_71"
        Me.tab_valor_escrita_71.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_71.TabIndex = 2519
        Me.tab_valor_escrita_71.Text = "0"
        Me.tab_valor_escrita_71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_72
        '
        Me.tab_valor_escrita_72.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_72.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_72.CausesValidation = False
        Me.tab_valor_escrita_72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_72.Location = New System.Drawing.Point(695, 311)
        Me.tab_valor_escrita_72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_72.Name = "tab_valor_escrita_72"
        Me.tab_valor_escrita_72.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_72.TabIndex = 2519
        Me.tab_valor_escrita_72.Text = "0"
        Me.tab_valor_escrita_72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_73
        '
        Me.tab_valor_escrita_73.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_73.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_73.CausesValidation = False
        Me.tab_valor_escrita_73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_73.Location = New System.Drawing.Point(695, 339)
        Me.tab_valor_escrita_73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_73.Name = "tab_valor_escrita_73"
        Me.tab_valor_escrita_73.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_73.TabIndex = 2519
        Me.tab_valor_escrita_73.Text = "0"
        Me.tab_valor_escrita_73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_74
        '
        Me.tab_valor_escrita_74.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_74.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_74.CausesValidation = False
        Me.tab_valor_escrita_74.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_74.Location = New System.Drawing.Point(695, 367)
        Me.tab_valor_escrita_74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_74.Name = "tab_valor_escrita_74"
        Me.tab_valor_escrita_74.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_74.TabIndex = 2519
        Me.tab_valor_escrita_74.Text = "0"
        Me.tab_valor_escrita_74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_75
        '
        Me.tab_valor_escrita_75.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_75.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_75.CausesValidation = False
        Me.tab_valor_escrita_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_75.Location = New System.Drawing.Point(695, 395)
        Me.tab_valor_escrita_75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_75.Name = "tab_valor_escrita_75"
        Me.tab_valor_escrita_75.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_75.TabIndex = 2519
        Me.tab_valor_escrita_75.Text = "0"
        Me.tab_valor_escrita_75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_76
        '
        Me.tab_valor_escrita_76.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_76.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_76.CausesValidation = False
        Me.tab_valor_escrita_76.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_76.Location = New System.Drawing.Point(695, 423)
        Me.tab_valor_escrita_76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_76.Name = "tab_valor_escrita_76"
        Me.tab_valor_escrita_76.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_76.TabIndex = 2519
        Me.tab_valor_escrita_76.Text = "0"
        Me.tab_valor_escrita_76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_77
        '
        Me.tab_valor_escrita_77.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_77.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_77.CausesValidation = False
        Me.tab_valor_escrita_77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_77.Location = New System.Drawing.Point(695, 451)
        Me.tab_valor_escrita_77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_77.Name = "tab_valor_escrita_77"
        Me.tab_valor_escrita_77.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_77.TabIndex = 2519
        Me.tab_valor_escrita_77.Text = "0"
        Me.tab_valor_escrita_77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_78
        '
        Me.tab_valor_escrita_78.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_78.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_78.CausesValidation = False
        Me.tab_valor_escrita_78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_78.Location = New System.Drawing.Point(695, 479)
        Me.tab_valor_escrita_78.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_78.Name = "tab_valor_escrita_78"
        Me.tab_valor_escrita_78.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_78.TabIndex = 2519
        Me.tab_valor_escrita_78.Text = "0"
        Me.tab_valor_escrita_78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_79
        '
        Me.tab_valor_escrita_79.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_79.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_79.CausesValidation = False
        Me.tab_valor_escrita_79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_79.Location = New System.Drawing.Point(695, 507)
        Me.tab_valor_escrita_79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_79.Name = "tab_valor_escrita_79"
        Me.tab_valor_escrita_79.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_79.TabIndex = 2519
        Me.tab_valor_escrita_79.Text = "0"
        Me.tab_valor_escrita_79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_80
        '
        Me.tab_valor_escrita_80.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_80.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_80.CausesValidation = False
        Me.tab_valor_escrita_80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_80.Location = New System.Drawing.Point(695, 540)
        Me.tab_valor_escrita_80.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_80.Name = "tab_valor_escrita_80"
        Me.tab_valor_escrita_80.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_80.TabIndex = 2519
        Me.tab_valor_escrita_80.Text = "0"
        Me.tab_valor_escrita_80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_81
        '
        Me.tab_valor_escrita_81.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_81.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_81.CausesValidation = False
        Me.tab_valor_escrita_81.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_81.Location = New System.Drawing.Point(916, 3)
        Me.tab_valor_escrita_81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_81.Name = "tab_valor_escrita_81"
        Me.tab_valor_escrita_81.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_81.TabIndex = 2519
        Me.tab_valor_escrita_81.Text = "0"
        Me.tab_valor_escrita_81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_82
        '
        Me.tab_valor_escrita_82.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_82.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_82.CausesValidation = False
        Me.tab_valor_escrita_82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_82.Location = New System.Drawing.Point(916, 31)
        Me.tab_valor_escrita_82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_82.Name = "tab_valor_escrita_82"
        Me.tab_valor_escrita_82.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_82.TabIndex = 2519
        Me.tab_valor_escrita_82.Text = "0"
        Me.tab_valor_escrita_82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_83
        '
        Me.tab_valor_escrita_83.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_83.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_83.CausesValidation = False
        Me.tab_valor_escrita_83.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_83.Location = New System.Drawing.Point(916, 59)
        Me.tab_valor_escrita_83.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_83.Name = "tab_valor_escrita_83"
        Me.tab_valor_escrita_83.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_83.TabIndex = 2519
        Me.tab_valor_escrita_83.Text = "0"
        Me.tab_valor_escrita_83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_84
        '
        Me.tab_valor_escrita_84.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_84.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_84.CausesValidation = False
        Me.tab_valor_escrita_84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_84.Location = New System.Drawing.Point(916, 87)
        Me.tab_valor_escrita_84.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_84.Name = "tab_valor_escrita_84"
        Me.tab_valor_escrita_84.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_84.TabIndex = 2519
        Me.tab_valor_escrita_84.Text = "0"
        Me.tab_valor_escrita_84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_85
        '
        Me.tab_valor_escrita_85.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_85.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_85.CausesValidation = False
        Me.tab_valor_escrita_85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_85.Location = New System.Drawing.Point(916, 115)
        Me.tab_valor_escrita_85.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_85.Name = "tab_valor_escrita_85"
        Me.tab_valor_escrita_85.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_85.TabIndex = 2519
        Me.tab_valor_escrita_85.Text = "0"
        Me.tab_valor_escrita_85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_86
        '
        Me.tab_valor_escrita_86.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_86.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_86.CausesValidation = False
        Me.tab_valor_escrita_86.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_86.Location = New System.Drawing.Point(916, 143)
        Me.tab_valor_escrita_86.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_86.Name = "tab_valor_escrita_86"
        Me.tab_valor_escrita_86.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_86.TabIndex = 2519
        Me.tab_valor_escrita_86.Text = "0"
        Me.tab_valor_escrita_86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_87
        '
        Me.tab_valor_escrita_87.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_87.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_87.CausesValidation = False
        Me.tab_valor_escrita_87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_87.Location = New System.Drawing.Point(916, 171)
        Me.tab_valor_escrita_87.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_87.Name = "tab_valor_escrita_87"
        Me.tab_valor_escrita_87.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_87.TabIndex = 2519
        Me.tab_valor_escrita_87.Text = "0"
        Me.tab_valor_escrita_87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_88
        '
        Me.tab_valor_escrita_88.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_88.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_88.CausesValidation = False
        Me.tab_valor_escrita_88.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_88.Location = New System.Drawing.Point(916, 199)
        Me.tab_valor_escrita_88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_88.Name = "tab_valor_escrita_88"
        Me.tab_valor_escrita_88.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_88.TabIndex = 2519
        Me.tab_valor_escrita_88.Text = "0"
        Me.tab_valor_escrita_88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_89
        '
        Me.tab_valor_escrita_89.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_89.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_89.CausesValidation = False
        Me.tab_valor_escrita_89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_89.Location = New System.Drawing.Point(916, 227)
        Me.tab_valor_escrita_89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_89.Name = "tab_valor_escrita_89"
        Me.tab_valor_escrita_89.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_89.TabIndex = 2519
        Me.tab_valor_escrita_89.Text = "0"
        Me.tab_valor_escrita_89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_90
        '
        Me.tab_valor_escrita_90.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_90.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_90.CausesValidation = False
        Me.tab_valor_escrita_90.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_90.Location = New System.Drawing.Point(916, 255)
        Me.tab_valor_escrita_90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_90.Name = "tab_valor_escrita_90"
        Me.tab_valor_escrita_90.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_90.TabIndex = 2519
        Me.tab_valor_escrita_90.Text = "0"
        Me.tab_valor_escrita_90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_91
        '
        Me.tab_valor_escrita_91.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_91.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_91.CausesValidation = False
        Me.tab_valor_escrita_91.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_91.Location = New System.Drawing.Point(916, 283)
        Me.tab_valor_escrita_91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_91.Name = "tab_valor_escrita_91"
        Me.tab_valor_escrita_91.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_91.TabIndex = 2519
        Me.tab_valor_escrita_91.Text = "0"
        Me.tab_valor_escrita_91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_92
        '
        Me.tab_valor_escrita_92.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_92.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_92.CausesValidation = False
        Me.tab_valor_escrita_92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_92.Location = New System.Drawing.Point(916, 311)
        Me.tab_valor_escrita_92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_92.Name = "tab_valor_escrita_92"
        Me.tab_valor_escrita_92.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_92.TabIndex = 2519
        Me.tab_valor_escrita_92.Text = "0"
        Me.tab_valor_escrita_92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_93
        '
        Me.tab_valor_escrita_93.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_93.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_93.CausesValidation = False
        Me.tab_valor_escrita_93.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_93.Location = New System.Drawing.Point(916, 339)
        Me.tab_valor_escrita_93.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_93.Name = "tab_valor_escrita_93"
        Me.tab_valor_escrita_93.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_93.TabIndex = 2519
        Me.tab_valor_escrita_93.Text = "0"
        Me.tab_valor_escrita_93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_94
        '
        Me.tab_valor_escrita_94.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_94.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_94.CausesValidation = False
        Me.tab_valor_escrita_94.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_94.Location = New System.Drawing.Point(916, 367)
        Me.tab_valor_escrita_94.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_94.Name = "tab_valor_escrita_94"
        Me.tab_valor_escrita_94.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_94.TabIndex = 2519
        Me.tab_valor_escrita_94.Text = "0"
        Me.tab_valor_escrita_94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_95
        '
        Me.tab_valor_escrita_95.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_95.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_95.CausesValidation = False
        Me.tab_valor_escrita_95.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_95.Location = New System.Drawing.Point(916, 395)
        Me.tab_valor_escrita_95.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_95.Name = "tab_valor_escrita_95"
        Me.tab_valor_escrita_95.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_95.TabIndex = 2519
        Me.tab_valor_escrita_95.Text = "0"
        Me.tab_valor_escrita_95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_96
        '
        Me.tab_valor_escrita_96.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_96.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_96.CausesValidation = False
        Me.tab_valor_escrita_96.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_96.Location = New System.Drawing.Point(916, 423)
        Me.tab_valor_escrita_96.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_96.Name = "tab_valor_escrita_96"
        Me.tab_valor_escrita_96.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_96.TabIndex = 2519
        Me.tab_valor_escrita_96.Text = "0"
        Me.tab_valor_escrita_96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_97
        '
        Me.tab_valor_escrita_97.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_97.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_97.CausesValidation = False
        Me.tab_valor_escrita_97.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_97.Location = New System.Drawing.Point(916, 451)
        Me.tab_valor_escrita_97.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_97.Name = "tab_valor_escrita_97"
        Me.tab_valor_escrita_97.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_97.TabIndex = 2519
        Me.tab_valor_escrita_97.Text = "0"
        Me.tab_valor_escrita_97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_98
        '
        Me.tab_valor_escrita_98.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_98.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_98.CausesValidation = False
        Me.tab_valor_escrita_98.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_98.Location = New System.Drawing.Point(916, 479)
        Me.tab_valor_escrita_98.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_98.Name = "tab_valor_escrita_98"
        Me.tab_valor_escrita_98.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_98.TabIndex = 2519
        Me.tab_valor_escrita_98.Text = "0"
        Me.tab_valor_escrita_98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_99
        '
        Me.tab_valor_escrita_99.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_99.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_99.CausesValidation = False
        Me.tab_valor_escrita_99.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_99.Location = New System.Drawing.Point(916, 507)
        Me.tab_valor_escrita_99.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_99.Name = "tab_valor_escrita_99"
        Me.tab_valor_escrita_99.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_99.TabIndex = 2519
        Me.tab_valor_escrita_99.Text = "0"
        Me.tab_valor_escrita_99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_valor_escrita_100
        '
        Me.tab_valor_escrita_100.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_valor_escrita_100.BackColor = System.Drawing.Color.White
        Me.tab_valor_escrita_100.CausesValidation = False
        Me.tab_valor_escrita_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_valor_escrita_100.Location = New System.Drawing.Point(916, 540)
        Me.tab_valor_escrita_100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tab_valor_escrita_100.Name = "tab_valor_escrita_100"
        Me.tab_valor_escrita_100.Size = New System.Drawing.Size(125, 25)
        Me.tab_valor_escrita_100.TabIndex = 2519
        Me.tab_valor_escrita_100.Text = "0"
        Me.tab_valor_escrita_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Form_mbslave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1412, 823)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_mbslave"
        Me.Text = "COMUNICAÇÃO"
        Me.Grupo_1.ResumeLayout(False)
        Me.Grupo_1.PerformLayout
        Me.Grupo_2.ResumeLayout(False)
        Me.Grupo_2.PerformLayout
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(False)
        Me.Config.ResumeLayout(False)
        Me.Config.PerformLayout
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout
        CType(Me.reg_escrita_inicio, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.reg_escrita_tamanho, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        CType(Me.reg_leitura_inicio, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.reg_leitura_tamanho, System.ComponentModel.ISupportInitialize).EndInit
        Me.Leitura.ResumeLayout(False)
        Me.Leitura.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel_leitura.ResumeLayout(False)
        Me.Panel_leitura.PerformLayout
        CType(Me.valor_sel, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tab_leitura_inicio, System.ComponentModel.ISupportInitialize).EndInit
        Me.Escrita.ResumeLayout(False)
        Me.Escrita.PerformLayout
        CType(Me.tab_escrita_inicio, System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grupo_1 As System.Windows.Forms.GroupBox
    Friend WithEvents bt_Sair As System.Windows.Forms.Button
    Friend WithEvents cb_Endereco As System.Windows.Forms.ComboBox
    Friend WithEvents bt_at_port As System.Windows.Forms.Button
    Friend WithEvents bt_Conect As System.Windows.Forms.Button
    Friend WithEvents ComboBox_AvailableSerialPorts As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Grupo_2 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_serial_transacoes As System.Windows.Forms.TextBox
    Friend WithEvents Reset_cont_erro_serial As System.Windows.Forms.Button
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TB_serial_erro_endereco As System.Windows.Forms.TextBox
    Friend WithEvents TB_serial_erro_crc As System.Windows.Forms.TextBox
    Friend WithEvents TB_serial_erro_total As System.Windows.Forms.TextBox
    Friend WithEvents LB_versao As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents spModBus As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_frame As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Config As TabPage
    Friend WithEvents Leitura As TabPage
    Friend WithEvents Escrita As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tab_endereco_leitura_1 As Label
    Friend WithEvents Panel_leitura As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents reg_sel As Label
    Friend WithEvents valor_sel As NumericUpDown
    Friend WithEvents RadioButton_decrementa As RadioButton
    Friend WithEvents RadioButton_Normal As RadioButton
    Friend WithEvents RadioButton_Incrementa As RadioButton
    Friend WithEvents tab_valor_leitura_1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents reg_leitura_tamanho As NumericUpDown
    Friend WithEvents reg_leitura_inicio As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents tab_leitura_inicio As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents reg_escrita_tamanho As NumericUpDown
    Friend WithEvents reg_escrita_inicio As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tab_endereco_leitura_2 As Label
    Friend WithEvents tab_endereco_leitura_3 As Label
    Friend WithEvents tab_endereco_leitura_4 As Label
    Friend WithEvents tab_endereco_leitura_5 As Label
    Friend WithEvents tab_endereco_leitura_6 As Label
    Friend WithEvents tab_endereco_leitura_7 As Label
    Friend WithEvents tab_endereco_leitura_8 As Label
    Friend WithEvents tab_endereco_leitura_9 As Label
    Friend WithEvents tab_endereco_leitura_10 As Label
    Friend WithEvents tab_endereco_leitura_11 As Label
    Friend WithEvents tab_endereco_leitura_12 As Label
    Friend WithEvents tab_endereco_leitura_13 As Label
    Friend WithEvents tab_endereco_leitura_14 As Label
    Friend WithEvents tab_endereco_leitura_15 As Label
    Friend WithEvents tab_endereco_leitura_16 As Label
    Friend WithEvents tab_endereco_leitura_17 As Label
    Friend WithEvents tab_endereco_leitura_18 As Label
    Friend WithEvents tab_endereco_leitura_19 As Label
    Friend WithEvents tab_endereco_leitura_20 As Label
    Friend WithEvents tab_endereco_leitura_21 As Label
    Friend WithEvents tab_endereco_leitura_22 As Label
    Friend WithEvents tab_endereco_leitura_23 As Label
    Friend WithEvents tab_endereco_leitura_24 As Label
    Friend WithEvents tab_endereco_leitura_25 As Label
    Friend WithEvents tab_endereco_leitura_26 As Label
    Friend WithEvents tab_endereco_leitura_27 As Label
    Friend WithEvents tab_endereco_leitura_28 As Label
    Friend WithEvents tab_endereco_leitura_29 As Label
    Friend WithEvents tab_endereco_leitura_30 As Label
    Friend WithEvents tab_endereco_leitura_31 As Label
    Friend WithEvents tab_endereco_leitura_32 As Label
    Friend WithEvents tab_endereco_leitura_33 As Label
    Friend WithEvents tab_endereco_leitura_34 As Label
    Friend WithEvents tab_endereco_leitura_35 As Label
    Friend WithEvents tab_endereco_leitura_36 As Label
    Friend WithEvents tab_endereco_leitura_37 As Label
    Friend WithEvents tab_endereco_leitura_38 As Label
    Friend WithEvents tab_endereco_leitura_39 As Label
    Friend WithEvents tab_endereco_leitura_40 As Label
    Friend WithEvents tab_endereco_leitura_41 As Label
    Friend WithEvents tab_endereco_leitura_42 As Label
    Friend WithEvents tab_endereco_leitura_43 As Label
    Friend WithEvents tab_endereco_leitura_44 As Label
    Friend WithEvents tab_endereco_leitura_45 As Label
    Friend WithEvents tab_endereco_leitura_46 As Label
    Friend WithEvents tab_endereco_leitura_47 As Label
    Friend WithEvents tab_endereco_leitura_48 As Label
    Friend WithEvents tab_endereco_leitura_49 As Label
    Friend WithEvents tab_endereco_leitura_50 As Label
    Friend WithEvents tab_endereco_leitura_51 As Label
    Friend WithEvents tab_endereco_leitura_52 As Label
    Friend WithEvents tab_endereco_leitura_53 As Label
    Friend WithEvents tab_endereco_leitura_54 As Label
    Friend WithEvents tab_endereco_leitura_55 As Label
    Friend WithEvents tab_endereco_leitura_56 As Label
    Friend WithEvents tab_endereco_leitura_57 As Label
    Friend WithEvents tab_endereco_leitura_58 As Label
    Friend WithEvents tab_endereco_leitura_59 As Label
    Friend WithEvents tab_endereco_leitura_60 As Label
    Friend WithEvents tab_endereco_leitura_61 As Label
    Friend WithEvents tab_endereco_leitura_62 As Label
    Friend WithEvents tab_endereco_leitura_63 As Label
    Friend WithEvents tab_endereco_leitura_64 As Label
    Friend WithEvents tab_endereco_leitura_65 As Label
    Friend WithEvents tab_endereco_leitura_66 As Label
    Friend WithEvents tab_endereco_leitura_67 As Label
    Friend WithEvents tab_endereco_leitura_68 As Label
    Friend WithEvents tab_endereco_leitura_69 As Label
    Friend WithEvents tab_endereco_leitura_70 As Label
    Friend WithEvents tab_endereco_leitura_71 As Label
    Friend WithEvents tab_endereco_leitura_72 As Label
    Friend WithEvents tab_endereco_leitura_73 As Label
    Friend WithEvents tab_endereco_leitura_74 As Label
    Friend WithEvents tab_endereco_leitura_75 As Label
    Friend WithEvents tab_endereco_leitura_76 As Label
    Friend WithEvents tab_endereco_leitura_77 As Label
    Friend WithEvents tab_endereco_leitura_78 As Label
    Friend WithEvents tab_endereco_leitura_79 As Label
    Friend WithEvents tab_endereco_leitura_80 As Label
    Friend WithEvents tab_endereco_leitura_81 As Label
    Friend WithEvents tab_endereco_leitura_82 As Label
    Friend WithEvents tab_endereco_leitura_83 As Label
    Friend WithEvents tab_endereco_leitura_84 As Label
    Friend WithEvents tab_endereco_leitura_85 As Label
    Friend WithEvents tab_endereco_leitura_86 As Label
    Friend WithEvents tab_endereco_leitura_87 As Label
    Friend WithEvents tab_endereco_leitura_88 As Label
    Friend WithEvents tab_endereco_leitura_89 As Label
    Friend WithEvents tab_endereco_leitura_90 As Label
    Friend WithEvents tab_endereco_leitura_91 As Label
    Friend WithEvents tab_endereco_leitura_92 As Label
    Friend WithEvents tab_endereco_leitura_93 As Label
    Friend WithEvents tab_endereco_leitura_94 As Label
    Friend WithEvents tab_endereco_leitura_95 As Label
    Friend WithEvents tab_endereco_leitura_96 As Label
    Friend WithEvents tab_endereco_leitura_97 As Label
    Friend WithEvents tab_endereco_leitura_98 As Label
    Friend WithEvents tab_endereco_leitura_99 As Label
    Friend WithEvents tab_endereco_leitura_100 As Label
    Friend WithEvents tab_valor_leitura_2 As Label
    Friend WithEvents tab_valor_leitura_3 As Label
    Friend WithEvents tab_valor_leitura_4 As Label
    Friend WithEvents tab_valor_leitura_5 As Label
    Friend WithEvents tab_valor_leitura_6 As Label
    Friend WithEvents tab_valor_leitura_7 As Label
    Friend WithEvents tab_valor_leitura_8 As Label
    Friend WithEvents tab_valor_leitura_9 As Label
    Friend WithEvents tab_valor_leitura_10 As Label
    Friend WithEvents tab_valor_leitura_11 As Label
    Friend WithEvents tab_valor_leitura_12 As Label
    Friend WithEvents tab_valor_leitura_13 As Label
    Friend WithEvents tab_valor_leitura_14 As Label
    Friend WithEvents tab_valor_leitura_15 As Label
    Friend WithEvents tab_valor_leitura_16 As Label
    Friend WithEvents tab_valor_leitura_17 As Label
    Friend WithEvents tab_valor_leitura_18 As Label
    Friend WithEvents tab_valor_leitura_19 As Label
    Friend WithEvents tab_valor_leitura_20 As Label
    Friend WithEvents tab_valor_leitura_21 As Label
    Friend WithEvents tab_valor_leitura_22 As Label
    Friend WithEvents tab_valor_leitura_23 As Label
    Friend WithEvents tab_valor_leitura_24 As Label
    Friend WithEvents tab_valor_leitura_25 As Label
    Friend WithEvents tab_valor_leitura_26 As Label
    Friend WithEvents tab_valor_leitura_27 As Label
    Friend WithEvents tab_valor_leitura_28 As Label
    Friend WithEvents tab_valor_leitura_29 As Label
    Friend WithEvents tab_valor_leitura_30 As Label
    Friend WithEvents tab_valor_leitura_31 As Label
    Friend WithEvents tab_valor_leitura_32 As Label
    Friend WithEvents tab_valor_leitura_33 As Label
    Friend WithEvents tab_valor_leitura_34 As Label
    Friend WithEvents tab_valor_leitura_35 As Label
    Friend WithEvents tab_valor_leitura_36 As Label
    Friend WithEvents tab_valor_leitura_37 As Label
    Friend WithEvents tab_valor_leitura_38 As Label
    Friend WithEvents tab_valor_leitura_39 As Label
    Friend WithEvents tab_valor_leitura_40 As Label
    Friend WithEvents tab_valor_leitura_41 As Label
    Friend WithEvents tab_valor_leitura_42 As Label
    Friend WithEvents tab_valor_leitura_43 As Label
    Friend WithEvents tab_valor_leitura_44 As Label
    Friend WithEvents tab_valor_leitura_45 As Label
    Friend WithEvents tab_valor_leitura_46 As Label
    Friend WithEvents tab_valor_leitura_47 As Label
    Friend WithEvents tab_valor_leitura_48 As Label
    Friend WithEvents tab_valor_leitura_49 As Label
    Friend WithEvents tab_valor_leitura_50 As Label
    Friend WithEvents tab_valor_leitura_51 As Label
    Friend WithEvents tab_valor_leitura_52 As Label
    Friend WithEvents tab_valor_leitura_53 As Label
    Friend WithEvents tab_valor_leitura_54 As Label
    Friend WithEvents tab_valor_leitura_55 As Label
    Friend WithEvents tab_valor_leitura_56 As Label
    Friend WithEvents tab_valor_leitura_57 As Label
    Friend WithEvents tab_valor_leitura_58 As Label
    Friend WithEvents tab_valor_leitura_59 As Label
    Friend WithEvents tab_valor_leitura_60 As Label
    Friend WithEvents tab_valor_leitura_61 As Label
    Friend WithEvents tab_valor_leitura_62 As Label
    Friend WithEvents tab_valor_leitura_63 As Label
    Friend WithEvents tab_valor_leitura_64 As Label
    Friend WithEvents tab_valor_leitura_65 As Label
    Friend WithEvents tab_valor_leitura_66 As Label
    Friend WithEvents tab_valor_leitura_67 As Label
    Friend WithEvents tab_valor_leitura_68 As Label
    Friend WithEvents tab_valor_leitura_69 As Label
    Friend WithEvents tab_valor_leitura_70 As Label
    Friend WithEvents tab_valor_leitura_71 As Label
    Friend WithEvents tab_valor_leitura_72 As Label
    Friend WithEvents tab_valor_leitura_73 As Label
    Friend WithEvents tab_valor_leitura_74 As Label
    Friend WithEvents tab_valor_leitura_75 As Label
    Friend WithEvents tab_valor_leitura_76 As Label
    Friend WithEvents tab_valor_leitura_77 As Label
    Friend WithEvents tab_valor_leitura_78 As Label
    Friend WithEvents tab_valor_leitura_79 As Label
    Friend WithEvents tab_valor_leitura_80 As Label
    Friend WithEvents tab_valor_leitura_81 As Label
    Friend WithEvents tab_valor_leitura_82 As Label
    Friend WithEvents tab_valor_leitura_83 As Label
    Friend WithEvents tab_valor_leitura_84 As Label
    Friend WithEvents tab_valor_leitura_85 As Label
    Friend WithEvents tab_valor_leitura_86 As Label
    Friend WithEvents tab_valor_leitura_87 As Label
    Friend WithEvents tab_valor_leitura_88 As Label
    Friend WithEvents tab_valor_leitura_89 As Label
    Friend WithEvents tab_valor_leitura_90 As Label
    Friend WithEvents tab_valor_leitura_91 As Label
    Friend WithEvents tab_valor_leitura_92 As Label
    Friend WithEvents tab_valor_leitura_93 As Label
    Friend WithEvents tab_valor_leitura_94 As Label
    Friend WithEvents tab_valor_leitura_95 As Label
    Friend WithEvents tab_valor_leitura_96 As Label
    Friend WithEvents tab_valor_leitura_97 As Label
    Friend WithEvents tab_valor_leitura_98 As Label
    Friend WithEvents tab_valor_leitura_99 As Label
    Friend WithEvents tab_valor_leitura_100 As Label
    Friend WithEvents Label216 As Label
    Friend WithEvents tab_escrita_inicio As NumericUpDown
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents tab_endereco_escrita_1 As Label
    Friend WithEvents tab_endereco_escrita_2 As Label
    Friend WithEvents tab_endereco_escrita_3 As Label
    Friend WithEvents tab_endereco_escrita_4 As Label
    Friend WithEvents tab_endereco_escrita_5 As Label
    Friend WithEvents tab_endereco_escrita_6 As Label
    Friend WithEvents tab_endereco_escrita_7 As Label
    Friend WithEvents tab_endereco_escrita_8 As Label
    Friend WithEvents tab_endereco_escrita_9 As Label
    Friend WithEvents tab_endereco_escrita_10 As Label
    Friend WithEvents tab_endereco_escrita_11 As Label
    Friend WithEvents tab_endereco_escrita_12 As Label
    Friend WithEvents tab_endereco_escrita_13 As Label
    Friend WithEvents tab_endereco_escrita_14 As Label
    Friend WithEvents tab_endereco_escrita_15 As Label
    Friend WithEvents tab_endereco_escrita_16 As Label
    Friend WithEvents tab_endereco_escrita_17 As Label
    Friend WithEvents tab_endereco_escrita_18 As Label
    Friend WithEvents tab_endereco_escrita_19 As Label
    Friend WithEvents tab_endereco_escrita_20 As Label
    Friend WithEvents tab_endereco_escrita_21 As Label
    Friend WithEvents tab_endereco_escrita_22 As Label
    Friend WithEvents tab_endereco_escrita_23 As Label
    Friend WithEvents tab_endereco_escrita_24 As Label
    Friend WithEvents tab_endereco_escrita_25 As Label
    Friend WithEvents tab_endereco_escrita_26 As Label
    Friend WithEvents tab_endereco_escrita_27 As Label
    Friend WithEvents tab_endereco_escrita_28 As Label
    Friend WithEvents tab_endereco_escrita_29 As Label
    Friend WithEvents tab_endereco_escrita_30 As Label
    Friend WithEvents tab_endereco_escrita_31 As Label
    Friend WithEvents tab_endereco_escrita_32 As Label
    Friend WithEvents tab_endereco_escrita_33 As Label
    Friend WithEvents tab_endereco_escrita_34 As Label
    Friend WithEvents tab_endereco_escrita_35 As Label
    Friend WithEvents tab_endereco_escrita_36 As Label
    Friend WithEvents tab_endereco_escrita_37 As Label
    Friend WithEvents tab_endereco_escrita_38 As Label
    Friend WithEvents tab_endereco_escrita_39 As Label
    Friend WithEvents tab_endereco_escrita_40 As Label
    Friend WithEvents tab_endereco_escrita_41 As Label
    Friend WithEvents tab_endereco_escrita_42 As Label
    Friend WithEvents tab_endereco_escrita_43 As Label
    Friend WithEvents tab_endereco_escrita_44 As Label
    Friend WithEvents tab_endereco_escrita_45 As Label
    Friend WithEvents tab_endereco_escrita_46 As Label
    Friend WithEvents tab_endereco_escrita_47 As Label
    Friend WithEvents tab_endereco_escrita_48 As Label
    Friend WithEvents tab_endereco_escrita_49 As Label
    Friend WithEvents tab_endereco_escrita_50 As Label
    Friend WithEvents tab_endereco_escrita_51 As Label
    Friend WithEvents tab_endereco_escrita_52 As Label
    Friend WithEvents tab_endereco_escrita_53 As Label
    Friend WithEvents tab_endereco_escrita_54 As Label
    Friend WithEvents tab_endereco_escrita_55 As Label
    Friend WithEvents tab_endereco_escrita_56 As Label
    Friend WithEvents tab_endereco_escrita_57 As Label
    Friend WithEvents tab_endereco_escrita_58 As Label
    Friend WithEvents tab_endereco_escrita_59 As Label
    Friend WithEvents tab_endereco_escrita_60 As Label
    Friend WithEvents tab_endereco_escrita_61 As Label
    Friend WithEvents tab_endereco_escrita_62 As Label
    Friend WithEvents tab_endereco_escrita_63 As Label
    Friend WithEvents tab_endereco_escrita_64 As Label
    Friend WithEvents tab_endereco_escrita_65 As Label
    Friend WithEvents tab_endereco_escrita_66 As Label
    Friend WithEvents tab_endereco_escrita_67 As Label
    Friend WithEvents tab_endereco_escrita_68 As Label
    Friend WithEvents tab_endereco_escrita_69 As Label
    Friend WithEvents tab_endereco_escrita_70 As Label
    Friend WithEvents tab_endereco_escrita_71 As Label
    Friend WithEvents tab_endereco_escrita_72 As Label
    Friend WithEvents tab_endereco_escrita_73 As Label
    Friend WithEvents tab_endereco_escrita_74 As Label
    Friend WithEvents tab_endereco_escrita_75 As Label
    Friend WithEvents tab_endereco_escrita_76 As Label
    Friend WithEvents tab_endereco_escrita_77 As Label
    Friend WithEvents tab_endereco_escrita_78 As Label
    Friend WithEvents tab_endereco_escrita_79 As Label
    Friend WithEvents tab_endereco_escrita_80 As Label
    Friend WithEvents tab_endereco_escrita_81 As Label
    Friend WithEvents tab_endereco_escrita_82 As Label
    Friend WithEvents tab_endereco_escrita_83 As Label
    Friend WithEvents tab_endereco_escrita_84 As Label
    Friend WithEvents tab_endereco_escrita_85 As Label
    Friend WithEvents tab_endereco_escrita_86 As Label
    Friend WithEvents tab_endereco_escrita_87 As Label
    Friend WithEvents tab_endereco_escrita_88 As Label
    Friend WithEvents tab_endereco_escrita_89 As Label
    Friend WithEvents tab_endereco_escrita_90 As Label
    Friend WithEvents tab_endereco_escrita_91 As Label
    Friend WithEvents tab_endereco_escrita_92 As Label
    Friend WithEvents tab_endereco_escrita_93 As Label
    Friend WithEvents tab_endereco_escrita_94 As Label
    Friend WithEvents tab_endereco_escrita_95 As Label
    Friend WithEvents tab_endereco_escrita_96 As Label
    Friend WithEvents tab_endereco_escrita_97 As Label
    Friend WithEvents tab_endereco_escrita_98 As Label
    Friend WithEvents tab_endereco_escrita_99 As Label
    Friend WithEvents tab_endereco_escrita_100 As Label
    Friend WithEvents tab_valor_escrita_1 As Label
    Friend WithEvents tab_valor_escrita_2 As Label
    Friend WithEvents tab_valor_escrita_3 As Label
    Friend WithEvents tab_valor_escrita_4 As Label
    Friend WithEvents tab_valor_escrita_5 As Label
    Friend WithEvents tab_valor_escrita_6 As Label
    Friend WithEvents tab_valor_escrita_7 As Label
    Friend WithEvents tab_valor_escrita_8 As Label
    Friend WithEvents tab_valor_escrita_9 As Label
    Friend WithEvents tab_valor_escrita_10 As Label
    Friend WithEvents tab_valor_escrita_11 As Label
    Friend WithEvents tab_valor_escrita_12 As Label
    Friend WithEvents tab_valor_escrita_13 As Label
    Friend WithEvents tab_valor_escrita_14 As Label
    Friend WithEvents tab_valor_escrita_15 As Label
    Friend WithEvents tab_valor_escrita_16 As Label
    Friend WithEvents tab_valor_escrita_17 As Label
    Friend WithEvents tab_valor_escrita_18 As Label
    Friend WithEvents tab_valor_escrita_19 As Label
    Friend WithEvents tab_valor_escrita_20 As Label
    Friend WithEvents tab_valor_escrita_21 As Label
    Friend WithEvents tab_valor_escrita_22 As Label
    Friend WithEvents tab_valor_escrita_23 As Label
    Friend WithEvents tab_valor_escrita_24 As Label
    Friend WithEvents tab_valor_escrita_25 As Label
    Friend WithEvents tab_valor_escrita_26 As Label
    Friend WithEvents tab_valor_escrita_27 As Label
    Friend WithEvents tab_valor_escrita_28 As Label
    Friend WithEvents tab_valor_escrita_29 As Label
    Friend WithEvents tab_valor_escrita_30 As Label
    Friend WithEvents tab_valor_escrita_31 As Label
    Friend WithEvents tab_valor_escrita_32 As Label
    Friend WithEvents tab_valor_escrita_33 As Label
    Friend WithEvents tab_valor_escrita_34 As Label
    Friend WithEvents tab_valor_escrita_35 As Label
    Friend WithEvents tab_valor_escrita_36 As Label
    Friend WithEvents tab_valor_escrita_37 As Label
    Friend WithEvents tab_valor_escrita_38 As Label
    Friend WithEvents tab_valor_escrita_39 As Label
    Friend WithEvents tab_valor_escrita_40 As Label
    Friend WithEvents tab_valor_escrita_41 As Label
    Friend WithEvents tab_valor_escrita_42 As Label
    Friend WithEvents tab_valor_escrita_43 As Label
    Friend WithEvents tab_valor_escrita_44 As Label
    Friend WithEvents tab_valor_escrita_45 As Label
    Friend WithEvents tab_valor_escrita_46 As Label
    Friend WithEvents tab_valor_escrita_47 As Label
    Friend WithEvents tab_valor_escrita_48 As Label
    Friend WithEvents tab_valor_escrita_49 As Label
    Friend WithEvents tab_valor_escrita_50 As Label
    Friend WithEvents tab_valor_escrita_51 As Label
    Friend WithEvents tab_valor_escrita_52 As Label
    Friend WithEvents tab_valor_escrita_53 As Label
    Friend WithEvents tab_valor_escrita_54 As Label
    Friend WithEvents tab_valor_escrita_55 As Label
    Friend WithEvents tab_valor_escrita_56 As Label
    Friend WithEvents tab_valor_escrita_57 As Label
    Friend WithEvents tab_valor_escrita_58 As Label
    Friend WithEvents tab_valor_escrita_59 As Label
    Friend WithEvents tab_valor_escrita_60 As Label
    Friend WithEvents tab_valor_escrita_61 As Label
    Friend WithEvents tab_valor_escrita_62 As Label
    Friend WithEvents tab_valor_escrita_63 As Label
    Friend WithEvents tab_valor_escrita_64 As Label
    Friend WithEvents tab_valor_escrita_65 As Label
    Friend WithEvents tab_valor_escrita_66 As Label
    Friend WithEvents tab_valor_escrita_67 As Label
    Friend WithEvents tab_valor_escrita_68 As Label
    Friend WithEvents tab_valor_escrita_69 As Label
    Friend WithEvents tab_valor_escrita_70 As Label
    Friend WithEvents tab_valor_escrita_71 As Label
    Friend WithEvents tab_valor_escrita_72 As Label
    Friend WithEvents tab_valor_escrita_73 As Label
    Friend WithEvents tab_valor_escrita_74 As Label
    Friend WithEvents tab_valor_escrita_75 As Label
    Friend WithEvents tab_valor_escrita_76 As Label
    Friend WithEvents tab_valor_escrita_77 As Label
    Friend WithEvents tab_valor_escrita_78 As Label
    Friend WithEvents tab_valor_escrita_79 As Label
    Friend WithEvents tab_valor_escrita_80 As Label
    Friend WithEvents tab_valor_escrita_81 As Label
    Friend WithEvents tab_valor_escrita_82 As Label
    Friend WithEvents tab_valor_escrita_83 As Label
    Friend WithEvents tab_valor_escrita_84 As Label
    Friend WithEvents tab_valor_escrita_85 As Label
    Friend WithEvents tab_valor_escrita_86 As Label
    Friend WithEvents tab_valor_escrita_87 As Label
    Friend WithEvents tab_valor_escrita_88 As Label
    Friend WithEvents tab_valor_escrita_89 As Label
    Friend WithEvents tab_valor_escrita_90 As Label
    Friend WithEvents tab_valor_escrita_91 As Label
    Friend WithEvents tab_valor_escrita_92 As Label
    Friend WithEvents tab_valor_escrita_93 As Label
    Friend WithEvents tab_valor_escrita_94 As Label
    Friend WithEvents tab_valor_escrita_95 As Label
    Friend WithEvents tab_valor_escrita_96 As Label
    Friend WithEvents tab_valor_escrita_97 As Label
    Friend WithEvents tab_valor_escrita_98 As Label
    Friend WithEvents tab_valor_escrita_99 As Label
    Friend WithEvents tab_valor_escrita_100 As Label
    Friend WithEvents BT_fecha As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BT_escrita_entra As Button
    Friend WithEvents BT_leitura_entra As Button
    Friend WithEvents BT_entra_sel As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_serial_exception_2 As TextBox
    Friend WithEvents TB_serial_exception_1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents velocidade As ComboBox
    Friend WithEvents Label12 As Label
End Class
