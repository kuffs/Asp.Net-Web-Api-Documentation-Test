# Asp.Net Web Api Documentation Test

Check out the various commits which show the stages that the project went through.

The end result allows for documentation to be generated for header parameters such as these:

        ''' <summary>
        ''' Log into using the username and password of a staff member
        ''' </summary>
        ''' <header name="user">The user name of the person requesting access</header>
        ''' <header name="pass">The password of the person requesting access</header>
        <HttpGet>


which will generate a section in the documentation like this

<dl>
<div style="background-color:#f6f8fa; padding:10px">
<h3>Header Parameters</h3>
        
    <table style="background-color:#f6f8fa">
        <thead>
            <tr><th>Name</th><th>Description</th><th>Type</th><th>Additional information</th></tr>
        </thead>
        <tbody>
                <tr>
                    <td>user</td>
                    <td>
                        <p>The user name of the person requesting access</p>
                    </td>
                    <td>
                        String
                    </td>
                    <td>
                            <p>None.</p>
 
                    </td>
                </tr>
                <tr>
                    <td>pass</td>
                    <td>
                        <p>The password of the person requesting access</p>
                    </td>
                    <td>
                        String
                    </td>
                    <td>
                         <p>None.</p>
                    </td>
                </tr>
        </tbody>
    </table><br></div></dl>