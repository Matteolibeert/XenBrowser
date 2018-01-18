Public Class XenBrowser

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        WebBrowser1.Navigate(TextBox1.Text)
        WebBrowser1.GoForward()
        WebBrowser1.GoBack()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        WebBrowser1.Refresh()


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        TextBox1.Text = WebBrowser1.Url.ToString

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        WebBrowser1.Navigate(My.Settings.Home)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Change.Click
        Dim response As Object
        response = InputBox("Please Enter Home Page URL", "Webbrowser", My.Settings.Home)
        My.Settings.Home = response
        My.Settings.Save()
    End Sub

    Private Sub Info_Click(sender As Object, e As EventArgs) Handles Info.Click
        MsgBox("Credits: Matteolibeert : The whole browser")
    End Sub
End Class
