'Dusty Beehler
'Mortal Combots 10547
'2017-2018 Season
'If used or modified please give proper credit, and link original repository
Public Class MainMenu
    'when the application loads it centers to screen
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'opens the excel form
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim frmExcel As New ExcelExporter
        frmExcel.ShowDialog()
    End Sub

    'opens text form
    Private Sub BtnText_Click(sender As Object, e As EventArgs) Handles BtnText.Click
        Dim frmTextExporter As New TextExporter
        frmTextExporter.ShowDialog()
        frmTextExporter.ShowInTaskbar = False
    End Sub

    'closes application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim frmAdd As New combotsAdd
        frmAdd.ShowDialog()
        Threading.Thread.Sleep(500)
        Me.Close()
    End Sub
End Class