Public Class ResponseError

    Public Code As Integer
    Public Message As String

    Public Sub New(ByVal code As Integer, ByVal message As String)
        Me.Code = code
        Me.Message = message
    End Sub

End Class