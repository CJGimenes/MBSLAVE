<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Porta_Serial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Porta_Serial))
        Me.Grupo_1 = New System.Windows.Forms.GroupBox()
        Me.PB_com = New System.Windows.Forms.PictureBox()
        Me.PB_setup_com = New System.Windows.Forms.PictureBox()
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
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TB_serial_erro_endereco = New System.Windows.Forms.TextBox()
        Me.TB_serial_erro_crc = New System.Windows.Forms.TextBox()
        Me.TB_serial_erro_total = New System.Windows.Forms.TextBox()
        Me.LB_versao = New System.Windows.Forms.Label()
        Me.BT_Modulos = New System.Windows.Forms.Button()
        Me.spModBus = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_frame = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TESTE = New System.Windows.Forms.Button()
        Me.label_cont_teste = New System.Windows.Forms.Label()
        Me.Grupo_1.SuspendLayout()
        CType(Me.PB_com, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_setup_com, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grupo_1
        '
        Me.Grupo_1.Controls.Add(Me.PB_com)
        Me.Grupo_1.Controls.Add(Me.PB_setup_com)
        Me.Grupo_1.Controls.Add(Me.bt_Sair)
        Me.Grupo_1.Controls.Add(Me.cb_Endereco)
        Me.Grupo_1.Controls.Add(Me.bt_at_port)
        Me.Grupo_1.Controls.Add(Me.bt_Conect)
        Me.Grupo_1.Controls.Add(Me.ComboBox_AvailableSerialPorts)
        Me.Grupo_1.Controls.Add(Me.Label8)
        Me.Grupo_1.Controls.Add(Me.Label7)
        Me.Grupo_1.Location = New System.Drawing.Point(36, 39)
        Me.Grupo_1.Name = "Grupo_1"
        Me.Grupo_1.Size = New System.Drawing.Size(190, 226)
        Me.Grupo_1.TabIndex = 2231
        Me.Grupo_1.TabStop = False
        Me.Grupo_1.Text = "  Porta Serial"
        '
        'PB_com
        '
        Me.PB_com.Image = Global.WindowsApplication1.My.Resources.Resources.com_n
        Me.PB_com.Location = New System.Drawing.Point(53, 178)
        Me.PB_com.Name = "PB_com"
        Me.PB_com.Size = New System.Drawing.Size(61, 32)
        Me.PB_com.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_com.TabIndex = 2225
        Me.PB_com.TabStop = False
        '
        'PB_setup_com
        '
        Me.PB_setup_com.Image = Global.WindowsApplication1.My.Resources.Resources.setup
        Me.PB_setup_com.Location = New System.Drawing.Point(6, 172)
        Me.PB_setup_com.Name = "PB_setup_com"
        Me.PB_setup_com.Size = New System.Drawing.Size(178, 44)
        Me.PB_setup_com.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_setup_com.TabIndex = 2224
        Me.PB_setup_com.TabStop = False
        '
        'bt_Sair
        '
        Me.bt_Sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Sair.Location = New System.Drawing.Point(113, 64)
        Me.bt_Sair.Name = "bt_Sair"
        Me.bt_Sair.Size = New System.Drawing.Size(55, 32)
        Me.bt_Sair.TabIndex = 2169
        Me.bt_Sair.Text = "Sair"
        Me.bt_Sair.UseVisualStyleBackColor = True
        '
        'cb_Endereco
        '
        Me.cb_Endereco.FormattingEnabled = True
        Me.cb_Endereco.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb_Endereco.Location = New System.Drawing.Point(113, 39)
        Me.cb_Endereco.Name = "cb_Endereco"
        Me.cb_Endereco.Size = New System.Drawing.Size(55, 21)
        Me.cb_Endereco.TabIndex = 2165
        '
        'bt_at_port
        '
        Me.bt_at_port.Location = New System.Drawing.Point(87, 39)
        Me.bt_at_port.Name = "bt_at_port"
        Me.bt_at_port.Size = New System.Drawing.Size(20, 21)
        Me.bt_at_port.TabIndex = 2167
        Me.bt_at_port.UseVisualStyleBackColor = True
        '
        'bt_Conect
        '
        Me.bt_Conect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Conect.Location = New System.Drawing.Point(22, 63)
        Me.bt_Conect.Name = "bt_Conect"
        Me.bt_Conect.Size = New System.Drawing.Size(84, 33)
        Me.bt_Conect.TabIndex = 2168
        Me.bt_Conect.Text = "Conect"
        Me.bt_Conect.UseVisualStyleBackColor = True
        '
        'ComboBox_AvailableSerialPorts
        '
        Me.ComboBox_AvailableSerialPorts.FormattingEnabled = True
        Me.ComboBox_AvailableSerialPorts.Location = New System.Drawing.Point(22, 39)
        Me.ComboBox_AvailableSerialPorts.Name = "ComboBox_AvailableSerialPorts"
        Me.ComboBox_AvailableSerialPorts.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox_AvailableSerialPorts.TabIndex = 2164
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(112, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 2223
        Me.Label8.Text = "Endereço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(39, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2223
        Me.Label7.Text = "Porta"
        '
        'Grupo_2
        '
        Me.Grupo_2.BackColor = System.Drawing.Color.Transparent
        Me.Grupo_2.Controls.Add(Me.TB_serial_transacoes)
        Me.Grupo_2.Controls.Add(Me.Reset_cont_erro_serial)
        Me.Grupo_2.Controls.Add(Me.Label72)
        Me.Grupo_2.Controls.Add(Me.Label70)
        Me.Grupo_2.Controls.Add(Me.Label69)
        Me.Grupo_2.Controls.Add(Me.Label1)
        Me.Grupo_2.Controls.Add(Me.Label68)
        Me.Grupo_2.Controls.Add(Me.Label71)
        Me.Grupo_2.Controls.Add(Me.TB_serial_erro_endereco)
        Me.Grupo_2.Controls.Add(Me.TB_serial_erro_crc)
        Me.Grupo_2.Controls.Add(Me.TB_serial_erro_total)
        Me.Grupo_2.Location = New System.Drawing.Point(247, 39)
        Me.Grupo_2.Name = "Grupo_2"
        Me.Grupo_2.Size = New System.Drawing.Size(203, 226)
        Me.Grupo_2.TabIndex = 2401
        Me.Grupo_2.TabStop = False
        Me.Grupo_2.Text = " Comunicação "
        '
        'TB_serial_transacoes
        '
        Me.TB_serial_transacoes.Location = New System.Drawing.Point(83, 137)
        Me.TB_serial_transacoes.Name = "TB_serial_transacoes"
        Me.TB_serial_transacoes.Size = New System.Drawing.Size(90, 20)
        Me.TB_serial_transacoes.TabIndex = 2398
        '
        'Reset_cont_erro_serial
        '
        Me.Reset_cont_erro_serial.Location = New System.Drawing.Point(153, 109)
        Me.Reset_cont_erro_serial.Name = "Reset_cont_erro_serial"
        Me.Reset_cont_erro_serial.Size = New System.Drawing.Size(20, 21)
        Me.Reset_cont_erro_serial.TabIndex = 2203
        Me.Reset_cont_erro_serial.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label72.Location = New System.Drawing.Point(18, 141)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(57, 13)
        Me.Label72.TabIndex = 2202
        Me.Label72.Text = "Trasações"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label70.Location = New System.Drawing.Point(22, 113)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(53, 13)
        Me.Label70.TabIndex = 2202
        Me.Label70.Text = "Total Erro"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label69.Location = New System.Drawing.Point(48, 86)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(29, 13)
        Me.Label69.TabIndex = 2202
        Me.Label69.Text = "CRC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(94, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2202
        Me.Label1.Text = "Erros"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label68.Location = New System.Drawing.Point(29, 59)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(53, 13)
        Me.Label68.TabIndex = 2202
        Me.Label68.Text = "Endereço"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label71.Location = New System.Drawing.Point(146, 90)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(35, 13)
        Me.Label71.TabIndex = 2202
        Me.Label71.Text = "Reset"
        '
        'TB_serial_erro_endereco
        '
        Me.TB_serial_erro_endereco.Location = New System.Drawing.Point(85, 56)
        Me.TB_serial_erro_endereco.Name = "TB_serial_erro_endereco"
        Me.TB_serial_erro_endereco.Size = New System.Drawing.Size(54, 20)
        Me.TB_serial_erro_endereco.TabIndex = 2172
        '
        'TB_serial_erro_crc
        '
        Me.TB_serial_erro_crc.Location = New System.Drawing.Point(85, 83)
        Me.TB_serial_erro_crc.Name = "TB_serial_erro_crc"
        Me.TB_serial_erro_crc.Size = New System.Drawing.Size(54, 20)
        Me.TB_serial_erro_crc.TabIndex = 2172
        '
        'TB_serial_erro_total
        '
        Me.TB_serial_erro_total.Location = New System.Drawing.Point(85, 110)
        Me.TB_serial_erro_total.Name = "TB_serial_erro_total"
        Me.TB_serial_erro_total.Size = New System.Drawing.Size(54, 20)
        Me.TB_serial_erro_total.TabIndex = 2172
        '
        'LB_versao
        '
        Me.LB_versao.AutoSize = True
        Me.LB_versao.Location = New System.Drawing.Point(696, 149)
        Me.LB_versao.Name = "LB_versao"
        Me.LB_versao.Size = New System.Drawing.Size(40, 13)
        Me.LB_versao.TabIndex = 2402
        Me.LB_versao.Text = "Versão"
        '
        'BT_Modulos
        '
        Me.BT_Modulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Modulos.Location = New System.Drawing.Point(665, 238)
        Me.BT_Modulos.Name = "BT_Modulos"
        Me.BT_Modulos.Size = New System.Drawing.Size(122, 27)
        Me.BT_Modulos.TabIndex = 2403
        Me.BT_Modulos.Text = "Módulos"
        Me.BT_Modulos.UseVisualStyleBackColor = True
        '
        'spModBus
        '
        Me.spModBus.BaudRate = 115200
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Timer_frame
        '
        Me.Timer_frame.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.cpqd
        Me.PictureBox1.Location = New System.Drawing.Point(635, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2404
        Me.PictureBox1.TabStop = False
        '
        'TESTE
        '
        Me.TESTE.Location = New System.Drawing.Point(487, 63)
        Me.TESTE.Name = "TESTE"
        Me.TESTE.Size = New System.Drawing.Size(81, 21)
        Me.TESTE.TabIndex = 2405
        Me.TESTE.Text = "TESTE"
        Me.TESTE.UseVisualStyleBackColor = True
        '
        'label_cont_teste
        '
        Me.label_cont_teste.AutoSize = True
        Me.label_cont_teste.Location = New System.Drawing.Point(526, 159)
        Me.label_cont_teste.Name = "label_cont_teste"
        Me.label_cont_teste.Size = New System.Drawing.Size(13, 13)
        Me.label_cont_teste.TabIndex = 2406
        Me.label_cont_teste.Text = "0"
        '
        'Porta_Serial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(823, 288)
        Me.Controls.Add(Me.label_cont_teste)
        Me.Controls.Add(Me.TESTE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LB_versao)
        Me.Controls.Add(Me.BT_Modulos)
        Me.Controls.Add(Me.Grupo_2)
        Me.Controls.Add(Me.Grupo_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Porta_Serial"
        Me.Text = "COMUNICAÇÃO"
        Me.Grupo_1.ResumeLayout(False)
        Me.Grupo_1.PerformLayout()
        CType(Me.PB_com, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_setup_com, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_2.ResumeLayout(False)
        Me.Grupo_2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grupo_1 As System.Windows.Forms.GroupBox
    Friend WithEvents PB_com As System.Windows.Forms.PictureBox
    Friend WithEvents PB_setup_com As System.Windows.Forms.PictureBox
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
    Friend WithEvents BT_Modulos As System.Windows.Forms.Button
    Friend WithEvents spModBus As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_frame As System.Windows.Forms.Timer
    Friend WithEvents TESTE As Button
    Friend WithEvents label_cont_teste As Label
    Friend WithEvents Label1 As Label
End Class
