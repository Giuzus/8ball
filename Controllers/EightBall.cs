using Microsoft.AspNetCore.Mvc;

namespace _8ball.Controllers;

[ApiController]
[Route("[controller]")]
public class EightBallController : ControllerBase
{
    private static readonly string[] answers = new[]
    {
        "It is certain.",
        "It is decidedly so.",
        "Without a doubt.",
        "Yes definitely.",
        "You may rely on it.",
        "As I see it, yes.",
        "Most likely.",
        "Outlook good.",
        "Yes.",
        "Signs point to yes.",
        "Reply hazy, try again.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don't count on it.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Very doubtful."
    };

    private readonly ILogger<EightBallController> _logger;

    public EightBallController(ILogger<EightBallController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{question}")]
    public ActionResult<string> Question(string question)
    {
        var rng = new Random(question.GetHashCode());

        return answers[rng.Next(answers.Length)];
    }
}
