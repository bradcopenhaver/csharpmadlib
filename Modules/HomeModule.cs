using Nancy;
using MadLibs.Objects;

namespace MadLibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["form.cshtml"];
      };
      Get["/story"] = _ => {
        StoryVariables myStoryVariables = new StoryVariables();
        myStoryVariables.SetPerson1(Request.Query["person1"]);
        myStoryVariables.SetPerson2(Request.Query["person2"]);
        myStoryVariables.SetAnimal(Request.Query["animal"]);
        myStoryVariables.SetExclamation(Request.Query["exclamation"]);
        myStoryVariables.SetExclamation2(Request.Query["exclamation2"]);
        myStoryVariables.SetVerb(Request.Query["verb"]);
        myStoryVariables.SetNoun(Request.Query["noun"]);
        myStoryVariables.SetNoun2(Request.Query["noun2"]);
        return View["story.cshtml", myStoryVariables];
      };
    }
  }
}
