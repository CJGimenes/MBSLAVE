Module Publicos


    Enum cmdEscrita
        Parado
        botaoEnvia
        escritaSimples
    End Enum

    Public escritaSimplesEndereco As Byte
    Public escritaSimplesValor As Byte
    Public comando_escrita As cmdEscrita
    Public final_um As Byte
    Public ponteiro_um As Byte
    Public botao_envia_todas As Boolean
    Public reg_pendencia_tx(31) As Boolean
    Public Sel_UM As Single

    Public endereco As Byte
    Public values As Short() = New Short(125) {}
    Public Uvalues As UShort() = New UShort(125) {}
    Public Tuvalues As UShort() = New UShort(125) {}
    Public frame_rx As Byte() = New Byte(256) {}
    Public frame_tx As Byte() = New Byte(256) {}

    Public input_register As UShort() = New UShort(1000) {}
    Public holding_register As UShort() = New UShort(1000) {}

    Public Const INI_TAB_COMANDO = 1
    Public Const INI_TAB_LEITURA = 1
    Public Const NUM_REG_COMANDO = 34
    Public Const NUM_REG_LEITURA = 4
    Public Const TEMPO_INATIVO = 10


    Public conec_flag As Boolean = False
    Public ReceivedMessage As String
    Public TranmitMessage As String

    Public modbusStatus As String
    Public flag_link As Boolean = False
    Public estado As Byte = 0
    Public modo As Byte = 0

    Public estado_link As Byte = 0

    Public num_ums As Byte = 1


End Module
