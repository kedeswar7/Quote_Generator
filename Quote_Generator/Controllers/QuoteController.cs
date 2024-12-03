using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quote_Generator.Models;
using System;
using System.Collections.Generic;

namespace Quote_Generator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        // Initialize the list of quotes
        private List<Class> quotes = new List<Class>
        {
            new Class { Id = 1, Quote = "No More Excuses until you finish", Author = "Kedeswar" },
            new Class { Id = 2, Quote = "Success is not final, failure is not fatal: It is the courage to continue that counts.", Author = "Winston Churchill" },
            new Class { Id = 3, Quote = "The only limit to our realization of tomorrow is our doubts of today.", Author = "Franklin D. Roosevelt" }
        };

        // Create a Random object for selecting random quotes
        private Random random = new Random();

        // GET api/quote/random
        [HttpGet("random")]
        public IActionResult GetRandomQuote()
        {
            // Generate a random index
            int randomIndex = random.Next(quotes.Count);

            // Retrieve the random quote
            Class randomQuote = quotes[randomIndex];

            // Return the quote as a JSON response
            return Ok(randomQuote);
        }
    }
}
