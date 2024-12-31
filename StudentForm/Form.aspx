<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="StudentForm.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:label ID="lblName" runat="server" Text="Name: "></asp:label>
            <input type="text" id="uname" runat="server" /><br /><br />

            <asp:label ID="lblEmail" runat="server" Text="Email: "></asp:label>
            <input type="email" id="email" runat="server" /><br /><br />

            <asp:label ID="lblDOB" runat="server" Text="DOB: "></asp:label>
            <input type="date" id="dob" runat="server" /><br /><br />

            <asp:label ID="lblPw" runat="server" Text="Password: "></asp:label>
            <input type="password" id="pw" runat="server" /><br /><br />

            <asp:label ID="lblRpw" runat="server" Text="Re-type Password: "></asp:label>
            <input type="password" id="rpw" runat="server" /><br /><br />

            <asp:label ID="lblGender" runat="server" Text="Gender: "></asp:label>
            <input type="radio" id="male" name="gender" value="male" runat="server" />
            <asp:Label runat="server" AssociatedControlID="male" Text="Male" />
            <input type="radio" id="female" name="gender" value="female" runat="server" />
            <asp:Label runat="server" AssociatedControlID="female" Text="Female" /><br /><br />

            <asp:label ID="lblHobbies" runat="server" Text="Hobbies: "></asp:label>
            <input type="checkbox" id="reading" value="Reading" runat="server" />
            <asp:Label runat="server" AssociatedControlID="reading" Text="Reading" />
            <input type="checkbox" id="swimming" value="Swimming" runat="server" />
            <asp:Label runat="server" AssociatedControlID="swimming" Text="Swimming" />
            <input type="checkbox" id="playing" value="Playing" runat="server" />
            <asp:Label runat="server" AssociatedControlID="playing" Text="Playing" /><br /><br />

            <asp:label ID="lblAddress" runat="server" Text="Address: "></asp:label>
            <textarea id="address" runat="server"></textarea><br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
           
        </div>
    </form>
</body>
</html>
