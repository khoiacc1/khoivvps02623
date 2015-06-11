Imports System.Data.SqlClient

Public Class frm_Login

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=ps02623.mssql.somee.com;packet size=4096;user id=khoivvps02623_SQLLogin_1;pwd=kcwc6omhvq;data source=ps02623.mssql.somee.com;persist security info=False;initial catalog=ps02623"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien where Manhanvien='" & txttaikhoan.Text & "' and Matkhau='" & txtmatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                frmquanly.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Function Main() As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Module1.ExitApp()
    End Sub


End Class
