<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeam
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
        Me.txtTeamResults = New System.Windows.Forms.TextBox()
        Me.btnHideMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTeamResults
        '
        Me.txtTeamResults.Location = New System.Drawing.Point(200, 28)
        Me.txtTeamResults.Name = "txtTeamResults"
        Me.txtTeamResults.Size = New System.Drawing.Size(313, 20)
        Me.txtTeamResults.TabIndex = 0
        Me.txtTeamResults.Text = "TEAM RESULTS"
        '
        'btnHideMe
        '
        Me.btnHideMe.Location = New System.Drawing.Point(730, 24)
        Me.btnHideMe.Name = "btnHideMe"
        Me.btnHideMe.Size = New System.Drawing.Size(65, 50)
        Me.btnHideMe.TabIndex = 1
        Me.btnHideMe.Text = "Hide form"
        Me.btnHideMe.UseVisualStyleBackColor = True
        '
        'frmTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHideMe)
        Me.Controls.Add(Me.txtTeamResults)
        Me.Name = "frmTeam"
        Me.Text = "Team Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTeamResults As TextBox
    Friend WithEvents btnHideMe As Button
End Class
