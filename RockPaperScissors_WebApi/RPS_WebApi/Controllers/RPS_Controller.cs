using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//A Random Number Generator (RNG) is a mathematical construct, either computational or as a hardware device that is designed to generate a random set of numbers that should not display any distinguishable patterns in their appearance or generation, hence the word random.*
namespace RPS_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPS_Controller : ControllerBase
    {
        //random variable
        public static Random rnd = new Random();
        
        //http request - get result
        [HttpPost("GetResult")]
        public GameResult GetResult(PlayRequest playRequest)
        {
            //null condition
            if (playRequest.PlayerChoice == null)
            {
                return null;
            }
            //init value
            string playerChoice = null;
            string cpuChoice = null;
            string result = null;

            //player choice
            //switch is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression.
            switch (playRequest.PlayerChoice.ToLower())
            {
                case "rock":
                    playerChoice = "Rock";
                    break;
                case "paper":
                    playerChoice = "Paper";
                    break;
                case "scissors":
                    playerChoice = "Scissors";
                    break;
                default:
                    return null;

            }

            //comp choice with random
            //int Random.Next(int minValue, int maxValue)
            var randomChoice = rnd.Next(1, (3 + 1));

            switch (randomChoice)
            {
                case 1:
                    cpuChoice = "Rock";
                    break;
                case 2:
                    cpuChoice = "Paper";
                    break;
                case 3:
                    cpuChoice = "Scissors";
                    break;
            }

            // result winning condition
            //draw
            if (playerChoice == cpuChoice)
            {
                result = "Draw";
            }
            //non draw
            else
            {
                if(playerChoice == "Rock" && cpuChoice == "Scissors")
                {
                    result = "Win";
                }
                else if(playerChoice == "Scissors" && cpuChoice == "Paper")
                {
                    result = "Win";
                }
                else if(playerChoice == "Paper" && cpuChoice == "Rock")
                {
                    result = "Win";
                }
                else
                {
                    result = "Lose";
                }
                
            }

            return new GameResult(playerChoice, cpuChoice, result);


        }
        
        
    }
}
