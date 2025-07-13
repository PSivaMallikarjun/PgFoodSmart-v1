using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using PgFoodSmart.Models;
using PgFoodSmart.Services;
using PgFoodSmart.Resources;

namespace PgFoodSmart.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MealController(IMealService mealService, IStringLocalizer<SharedResource> localizer) : ControllerBase
{
    [HttpPost("response")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RecordResponse([FromBody] MealResponse response)
    {
        if (response == null)
            return BadRequest(localizer["InvalidInput"]);

        if (string.IsNullOrWhiteSpace(response.MealType) || response.UserId <= 0)
            return BadRequest(localizer["MissingFields"]);

        await mealService.SaveResponse(response);
        return Ok(new
        {
            status = localizer["MealSaved"],
            mealType = response.MealType
        });
    }

    [HttpGet("report/{date}")]
    [ProducesResponseType(typeof(IEnumerable<MealResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetReport([FromRoute] DateTime date)
    {
        var data = await mealService.GetDailyReport(date);
        return Ok(data);
    }
}
