Public Class fLogin
	Private Sub Label1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bLogin.Click
		If Me.tUsername.Text = "admin" Then
			If Me.tPassword.Text = "admin" Then
				fHomeAdmin.Show()
				Me.Hide()
			End If
		Else
			fHomeUser.Show()
			Me.Hide()
		End If

	End Sub


End Class
