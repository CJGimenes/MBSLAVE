Imports System.Threading
Imports System.Security
Imports System.IO
Imports System.Text

Public Class Registros










    Public Sub Inicializa()




        Sem_Comunicacao()

    End Sub

    Public Sub Com_Comunicacao()

    End Sub

    Public Sub Sem_Comunicacao()

    End Sub


    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick


    End Sub


    Private Sub BT_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Porta_Serial.WindowState = FormWindowState.Normal
        Porta_Serial.Show()
        Porta_Serial.Select()
        Porta_Serial.Focus()
    End Sub

End Class