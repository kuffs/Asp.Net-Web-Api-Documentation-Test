Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Description
Imports System.Web.Http.Results
Imports System.Net.Http

Namespace Controllers
    Public Class TestController
        Inherits ApiController


        ''' <summary>
        ''' A function to test the api is alive
        ''' </summary>
        ''' <param name="V">The version of the API we wish to call</param>
        <HttpGet>
        <Route("Test", Name:="Test")>
        <ResponseType(GetType(String))>
        Public Function Test(Optional v As Integer = 1) As IHttpActionResult
            Return Ok($"Test Succeeded for controller. Version requested was {v}")
        End Function


        ''' <summary>
        ''' Log into using the username and password of a staff member
        ''' </summary>
        ''' <header name="user">The user name of the person requesting access</header>
        ''' <header name="pass">The password of the person requesting access</header>
        <HttpGet>
        <ResponseType(GetType(StaffMember))>
        <Route("LogIn", Name:="Login")>
        Public Function LogIn() As IHttpActionResult

            Try

                Dim values As IEnumerable(Of String) = Nothing

                Request.Headers.TryGetValues("user", values)
                Dim username = values?.FirstOrDefault

                Request.Headers.TryGetValues("pass", values)
                Dim password = values?.FirstOrDefault

                If username Is Nothing Or password Is Nothing Then
                    Return GetError(HttpStatusCode.Forbidden, "Username or Password missing")
                End If

                '' Test an actual login now we have credentials and return the relevant user details
                Dim staff = New StaffMember With {.ID = 1, .Name = "Joe Bloggs", .ApiKey = Guid.NewGuid.ToString}

                Return Ok(staff)

            Catch ex As Exception
                Return GetError(HttpStatusCode.InternalServerError, ex.Message)
            End Try

        End Function


        Private Function GetError(code As HttpStatusCode, message As String) As IHttpActionResult
            Return Content(code, New ResponseError(code, message))
        End Function

    End Class

End Namespace