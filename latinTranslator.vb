'Program Name: Latin Translator
'Developer: Maria Jackson
'Date: Feb 11, 2023
'Purpose: This program allows the user to click 1 of 3 Latin words (Sinister, Medium, Dexter)
'         Each button reveals the English translation when clicked
'         The user can click Exit to close the window at any time
Public Class latinTranslator
    Private Sub lblRight_Click(sender As Object, e As EventArgs) Handles lblRight.Click

    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        ' on click, shows lblRight, hides lblLeft & lblMiddle
        lblRight.Visible = True
        lblMiddle.Visible = False
        lblLeft.Visible = False

    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        ' on click, shows lblMiddle, hides lblRight & lblLeft
        lblMiddle.Visible = True
        lblRight.Visible = False
        lblLeft.Visible = False

    End Sub

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        ' on click, shows lblLeft, hides lblRight & lblMiddle
        lblLeft.Visible = True
        lblMiddle.Visible = False
        lblRight.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' on click, calls Close() and closes program window
        Close()
    End Sub
End Class
