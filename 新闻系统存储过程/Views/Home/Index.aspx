<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <table border="1">
            
        <%
          List<新闻系统存储过程.Models.NewsInfo>  newslist=     (List<新闻系统存储过程.Models.NewsInfo>)ViewData["data"];
          for (int i = 0; i < newslist.Count; i++)
          {
              Response.Write("<tr>");
              Response.Write("<td>");
              Response.Write(newslist[i].Id);
              Response.Write("</td>");
              Response.Write("<td>");
              Response.Write(newslist[i].Name);
              Response.Write("</td>");
              Response.Write("<td>");
              Response.Write(newslist[i].Author);
              Response.Write("</td>");
              Response.Write("<td>");
              Response.Write(newslist[i].Content);
              Response.Write("</td>");
              Response.Write("<td>");
              Response.Write(newslist[i].Datetime);
              Response.Write("</td>");
              Response.Write("</tr>");
          }
         %>
    </table>
    </div>
</body>
</html>
