using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ActionResult_dynamic.Results
{
    private readonly string _content;

    // Конструктор принимает контент, который нужно отобразить в HTML-разметке
    public HtmlResult(string content)
    {
        _content = content;
    }

    // Переопределение метода ExecuteResult для формирования HTML ответа
    public override void ExecuteResult(ControllerContext context)
    {
        if (context == null)
            throw new ArgumentNullException(nameof(context));

        // Формируем ответ в виде HTML страницы
        var response = context.HttpContext.Response;
        response.ContentType = "text/html";  // Устанавливаем тип контента как HTML

        var sb = new StringBuilder();
        sb.Append("<!DOCTYPE html>");
        sb.Append("<html lang=\"en\">");
        sb.Append("<head>");
        sb.Append("<meta charset=\"UTF-8\">");
        sb.Append("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
        sb.Append("<title>Custom HTML Result</title>");
        sb.Append("</head>");
        sb.Append("<body>");
        sb.Append(_content);  // Вставляем переданный контент
        sb.Append("</body>");
        sb.Append("</html>");

        // Пишем сгенерированную разметку в ответ
        response.Write(sb.ToString());
    }

}
