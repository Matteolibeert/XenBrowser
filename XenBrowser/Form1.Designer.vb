<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XenBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XenBrowser))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Change = New System.Windows.Forms.Button()
        Me.Info = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1415, 603)
        Me.WebBrowser1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(828, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Navigate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(909, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(413, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1328, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.Location = New System.Drawing.Point(77, 2)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(75, 23)
        Me.Home.TabIndex = 4
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.Change.Location = New System.Drawing.Point(158, 2)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(116, 23)
        Me.Change.TabIndex = 5
        Me.Change.Text = "Change Home Page"
        Me.Change.UseVisualStyleBackColor = True
        '
        'Info
        '
        Me.Info.Location = New System.Drawing.Point(-1, 2)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(75, 23)
        Me.Info.TabIndex = 6
        Me.Info.Text = "Info"
        Me.Info.UseVisualStyleBackColor = True
        '
        'XenBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 603)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "XenBrowser"
        Me.Text = "XenBrowser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Home As Button
    Friend WithEvents Change As Button
    Friend WithEvents Info As Button
End Class
