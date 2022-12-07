<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollOfTheDiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DiceRollListBox = New System.Windows.Forms.ListBox()
        Me.ListBoxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(136, 295)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(156, 67)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "Roll the Dice"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(313, 295)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(156, 67)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(494, 295)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(156, 67)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DiceRollListBox
        '
        Me.DiceRollListBox.ColumnWidth = 1
        Me.DiceRollListBox.FormattingEnabled = True
        Me.DiceRollListBox.ItemHeight = 20
        Me.DiceRollListBox.Location = New System.Drawing.Point(136, 63)
        Me.DiceRollListBox.Name = "DiceRollListBox"
        Me.DiceRollListBox.Size = New System.Drawing.Size(514, 144)
        Me.DiceRollListBox.TabIndex = 3
        '
        'ListBoxLabel
        '
        Me.ListBoxLabel.AutoSize = True
        Me.ListBoxLabel.Location = New System.Drawing.Point(336, 23)
        Me.ListBoxLabel.Name = "ListBoxLabel"
        Me.ListBoxLabel.Size = New System.Drawing.Size(112, 20)
        Me.ListBoxLabel.TabIndex = 4
        Me.ListBoxLabel.Text = "Roll of the Dice"
        '
        'RollOfTheDiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBoxLabel)
        Me.Controls.Add(Me.DiceRollListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Name = "RollOfTheDiceForm"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DiceRollListBox As ListBox
    Friend WithEvents ListBoxLabel As Label
End Class
