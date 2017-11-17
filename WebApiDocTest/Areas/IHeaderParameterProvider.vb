Imports System.Collections.ObjectModel
Imports System.Web.Http.Controllers
Imports WebApiDocTest.Areas.HelpPage.ModelDescriptions

Public Interface IHeaderParameterProvider

    Function GetHeaderParameters(descriptor As HttpActionDescriptor) As Collection(Of ParameterDescription)

End Interface
