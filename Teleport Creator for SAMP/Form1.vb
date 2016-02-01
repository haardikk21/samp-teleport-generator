Public Class Form1
    Dim newline As String = System.Environment.NewLine

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SAMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.sa-mp.com")
    End Sub

    Private Sub WikiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WikiToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://wiki.sa-mp.com")
    End Sub

    Private Sub SAMPForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMPForumsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://forum.sa-mp.com")
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Created by [HK]Ryder[AN],Thanks for Downloading.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox10.Clear()
        If TextBox7.Text.Length = 0 Then
            MsgBox("Please enter a command!")
        End If
        If CheckBox1.Checked = True Then
            If TextBox8.Text.Length = 0 Then
                MsgBox("Please enter a message to send!")
            End If
        End If
        If TextBox1.Text.Length = 0 Then
            MsgBox("Enter a X coordinate")
        End If
        If TextBox2.Text.Length = 0 Then
            MsgBox("Enter a Y coordinate")
        End If
        If TextBox3.Text.Length = 0 Then
            MsgBox("Enter a Z coordinate")
        End If
        If TextBox4.Text.Length = 0 Then
            MsgBox("Enter a angle")
        End If
        If TextBox5.Text.Length = 0 Then
            MsgBox("Enter a Interior ID")
        End If
        If TextBox6.Text.Length = 0 Then
            MsgBox("Enter a World ID")
        End If
        If RadioButton1.Checked = True Then
            TextBox10.Text = "if(!strcmp(cmdtext, ""/" & TextBox7.Text & """, true)){"
            TextBox10.Text = TextBox10.Text & newline & "   SetPlayerPos(playerid, " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "   SetPlayerFacingAngle(playerid, " & TextBox4.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "   SetPlayerInterior(playerid, " & TextBox5.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "   SetPlayerVirtualWorld(playerid, " & TextBox6.Text & ");"
            If CheckBox1.Checked = True Then
                TextBox10.Text = TextBox10.Text & newline & "   return SendClientMessage(playerid, -1, """ & TextBox8.Text & """);"
                TextBox10.Text = TextBox10.Text & newline & "}"
            Else
                TextBox10.Text = TextBox10.Text & newline & "   return 1;"
                TextBox10.Text = TextBox10.Text & newline & "}"
            End If
        Else
            TextBox10.Text = "if(!strcmp(cmdtext, ""/" & TextBox10.Text & """, true)){"
            TextBox10.Text = TextBox10.Text & newline & "   if(!IsPlayerInAnyVehicle(playerid)){"
            TextBox10.Text = TextBox10.Text & newline & "       SetPlayerPos(playerid, " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       SetPlayerFacingAngle(playerid, " & TextBox4.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       SetPlayerInterior(playerid, " & TextBox5.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       SetPlayerVirtualWorld(playerid, " & TextBox6.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "   }"
            TextBox10.Text = TextBox10.Text & newline & "   else{"
            TextBox10.Text = TextBox10.Text & newline & "       new veh = GetPlayerVehicleID(playerid);"
            TextBox10.Text = TextBox10.Text & newline & "       SetVehiclePos(veh, " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       SetVehicleZAngle(veh, " & TextBox4.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       LinkVehicleToInterior(veh, " & TextBox5.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       SetVehicleVirtualWorld(veh, " & TextBox6.Text & ");"
            TextBox10.Text = TextBox10.Text & newline & "       PutPlayerInVehicle(playerid, veh, 0);"
            TextBox10.Text = TextBox10.Text & newline & "   }"
            If CheckBox1.Checked = True Then
                TextBox10.Text = TextBox10.Text & newline & "   return SendClientMessage(playerid, -1, """ & TextBox8.Text & """);"
                TextBox10.Text = TextBox10.Text & newline & "}"
            Else
                TextBox10.Text = TextBox10.Text & newline & "   return 1;"
                TextBox10.Text = TextBox10.Text & newline & "}"
            End If
        End If
    End Sub
End Class
