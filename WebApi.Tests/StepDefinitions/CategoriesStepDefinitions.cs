using Model;
using TechTalk.SpecFlow;
using WebApi.Tests.Helpers;
using Xunit;

namespace WebApi.Tests.StepDefinitions;

[Binding]
public class CategoriesStepDefinitions : BaseTest
{
    const string WebMethodName = "categories";


    private string BaseAddress { get; set; }
    private HttpResponseMessage Response { get; set; } = null!;
    public string JsonResponse { get; set; }
    public string MoqFiles { get; set; }
    public string MoqFile { get; set; }

    public CategoriesStepDefinitions()
    {
        BaseAddress = "https://localhost:5000/api/v1.1/";

        MoqFiles = Directory.GetCurrentDirectory() + @"\json\categories.json";
        MoqFile = Directory.GetCurrentDirectory() + @"\json\category.json";
    }

    #region Get Categories

    [When(@"I make a GET request to '(.*)'")]
    public async Task WhenIMakeCategoriesRequestTo(string endpoint)
    {
        Response = await Client.GetAsync($"{BaseAddress}{endpoint}");
    }

    [When(@"When I make a GET request to 'categories'")]
    public async Task WhenCategoriesRequiredAttributesProvided()
    {
        Response = await Client.GetAsync($"{BaseAddress}{WebMethodName}");
    }

    #endregion



    #region Get Categories by Id

    [When(@"I make a GET request with id '(.*)' to '(.*)'")]
    public async Task WhenIMakeCategoryRequestWithIdTo(Guid id, string endpoint)
    {
        Response = await Client.GetAsync($"{BaseAddress}{WebMethodName}/{id.ToString()}");
    }

    #endregion


    #region Delete Categories

    [When(@"I make a DELETE request with id '(.*)' to '(.*)'")]
    public async Task WhenIMakeAdeleteRequestWithIdTo(Guid id, string endpoint)
    {
        //Response = await Client.DeleteAsync($"{BaseAddress}{WebMethodName}/{id.ToString()}");
    }

    #endregion

    #region Add Categories

    [When(@"I make a POST request with '(.*)' to '(.*)'")]
    public async Task WhenIMakeApostRequestWithTo(string file, string endpoint)
    {
        var item = ObjectData<List<Category>>(JsonResponse).FirstOrDefault();
        if (item is null)
            throw new Exception();

        item.Id = Guid.NewGuid();

        var data = JsonData(item);
        
        Response = await Client.PostAsync($"{BaseAddress}{endpoint}", data);

        var response = await Response.Content.ReadAsStringAsync();

        JsonResponse = response.JsonPrettify();

        Assert.True(!string.IsNullOrEmpty(JsonResponse));
    }

    #endregion

    #region Update Categories

    [When(@"I make a PUT request with '(.*)' to '(.*)'")]
    public async Task WhenIMakeAputRequestWithTo(Guid id, string endpoint)
    {
        var item = ObjectData<List<Category>>(JsonResponse).Where(x => x.Id == id).FirstOrDefault();
        if (item is null)
            throw new Exception();

        item.SubTitle = "test";

        var data = JsonData(item);

        Response = await Client.PutAsync($"{BaseAddress}{endpoint}/{id.ToString()}", data);

        var response = await Response.Content.ReadAsStringAsync();

        JsonResponse = response.JsonPrettify();

        Assert.True(!string.IsNullOrEmpty(JsonResponse));
    }

    [Then(@"the response entity should be '(.*)'")]
    public async Task ThenTheResponseEntityShouldBe(string file)
    {
        string path = "";

        switch (file)
        {
            case "category.json":
                path = File.ReadAllText(MoqFile);
                break;
            case "categories.json":
                path = File.ReadAllText(MoqFiles);
                break;
            default:
                break;
        }
        
        var expected = ObjectData<Category>(path);
        var actual = ObjectData<Category>(JsonResponse);

        Assert.Equal(expected is Category exp ? exp.SubTitle : string.Empty, actual is Category act ? act.SubTitle : string.Empty);
    }

    #endregion

    [Given(@"the repository has categories data")]
    public async Task GivenTheRepositoryHasCategoryData()
    {
        Response = await Client.GetAsync($"{BaseAddress}{WebMethodName}");

        var response = await Response.Content.ReadAsStringAsync();

        JsonResponse = response.JsonPrettify();

        Assert.True(!string.IsNullOrEmpty(JsonResponse));
    }

    [Then(@"the response json should be '(.*)'")]
    public async Task ThenTheResponseDataShouldBe(string file)
    {
        var response = await Response.Content.ReadAsStringAsync();

        string path = "";
        dynamic expected = null;
        dynamic actual = null;

        switch (file)
        {
            case "categories.json":
                path = File.ReadAllText(MoqFiles);
                expected = ObjectData<List<Category>>(path);
                actual = ObjectData<List<Category>>(response.JsonPrettify());


                if (expected is List<Category> expectedList && actual is List<Category> actualList)
                {
                    bool hasMatch = expectedList.Select(x => x.Id).Intersect(actualList.Select(n => n.Id)).Any();
                    Assert.True(hasMatch);
                }
                else
                {
                    Assert.True(false);
                }

                break;
            case "category.json":
                path = File.ReadAllText(MoqFile);
                expected = ObjectData<Category>(path);
                actual = ObjectData<Category>(response.JsonPrettify());

                Assert.Equal(expected is Category exp ? exp.Id : Guid.Empty, actual is Category act ? act.Id : Guid.Empty);
                break;
            default:
                break;
        }
    }


    [Then(@"the response status code is '(.*)'")]
    public void ThenTheResponseStatusCodeIs(int statusCode)
    {
        switch (statusCode)
        {
            case 200:
                Assert.True(Response.StatusCode == System.Net.HttpStatusCode.OK ? true : false);
            break;
            case 201:
                Assert.True(Response.StatusCode == System.Net.HttpStatusCode.Created ? true : false);
            break;
            default:
                break;
        }        
    }
}