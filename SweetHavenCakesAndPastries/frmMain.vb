Public Class frmMain
    Private currentForm As Form = Nothing

    Private Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Dispose()
        End If

        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(childForm)

        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New frmDashboard())
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(New frmDashboard())
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        OpenChildForm(New frmProducts())
    End Sub
End Class
