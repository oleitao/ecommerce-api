using Azure;
using Model;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using WebApi.Shared.DataTransferObjects;
using WebApi.Tests.Helpers;
using Xunit;

namespace WebApi.Tests.StepDefinitions;

[Binding]
public class StepDefinitions : BaseTest
{
    const string WebMethodName = "categories";

    private readonly ScenarioContext _scenarioContext;
    private readonly ISpecFlowOutputHelper _outputHelper;

    private string BaseAddress { get; set; }
    private HttpResponseMessage Response { get; set; } = null!;
    public string JsonResponse { get; set; }

    public StepDefinitions(ScenarioContext scenarioContext, ISpecFlowOutputHelper outputHelper)
    {
        BaseAddress = "https://localhost:5000/api/v1.1/";

        _scenarioContext = scenarioContext;
        _outputHelper = outputHelper;
    }


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


    [When(@"I make a GET request with id '(.*)' to '(.*)'")]
    public async Task WhenIMakeCategoryRequestWithIdTo(Guid id, string endpoint)
    {
        Response = await Client.GetAsync($"{BaseAddress}{endpoint}/{id.ToString()}");
    }


    [When(@"I make a DELETE request with id '(.*)' to '(.*)'")]
    public async Task WhenIMakeAdeleteRequestWithIdTo(Guid id, string endpoint)
    {
        //Response = await Client.DeleteAsync($"{BaseAddress}{endpoint}/{id.ToString()}");
    }


    [When(@"I make a POST request with '(.*)' to '(.*)'")]
    public async Task WhenIMakeApostRequestWithTo(string file, string endpoint)
    {
        dynamic item = null;

        switch (endpoint)
        {
            case "categories":
                item = ObjectData<List<Category>>(JsonResponse).FirstOrDefault();
                break;
            case "imageurls":
                item = ObjectData<List<ImageUrl>>(JsonResponse).FirstOrDefault();
                break;

            case "reviews":
                item = ObjectData<List<Review>>(JsonResponse).FirstOrDefault();
                break;
            case "shops":
                item = ObjectData<List<Shop>>(JsonResponse).FirstOrDefault();
                break;
            case "shopavatars":
                item = ObjectData<List<ShopAvatar>>(JsonResponse).FirstOrDefault();
                break;
            case "users":
                item = ObjectData<List<User>>(JsonResponse).FirstOrDefault();
                break;
            default:
                break;
        }

        if (item is null)
            throw new Exception();

        item.Id = Guid.NewGuid();

        var data = JsonData(item);

        Response = await Client.PostAsync($"{BaseAddress}{endpoint}", data);

        var response = await Response.Content.ReadAsStringAsync();

        JsonResponse = response.JsonPrettify();

        Assert.True(!string.IsNullOrEmpty(JsonResponse));
    }


    [When(@"I make a PUT request with '(.*)' to '(.*)'")]
    public async Task WhenIMakeAputRequestWithTo(Guid id, string endpoint)
    {
        //var item = ObjectData<List<Category>>(JsonResponse).Where(x => x.Id == id).FirstOrDefault();
        //if (item is null)
        //    throw new Exception();

        dynamic item = null;

        switch (endpoint)
        {
            case "categories":
                item = ObjectData<List<Category>>(JsonResponse).FirstOrDefault();
                if(item is Category category)
                    category.SubTitle = "test";
                break;
            case "imageurls":
                item = ObjectData<List<ImageUrl>>(JsonResponse).FirstOrDefault();
                if(item is ImageUrl imageUrl)
                    imageUrl.Public_id = "test";
                break;
            default:
                break;
        }

        if (item is null)
            throw new Exception();

        

        var data = JsonData(item);

        Response = await Client.PutAsync($"{BaseAddress}{endpoint}/{id.ToString()}", data);

        var response = await Response.Content.ReadAsStringAsync();

        JsonResponse = response.JsonPrettify();

        Assert.True(!string.IsNullOrEmpty(JsonResponse));
    }

    [Then(@"the response entity should be '(.*)'")]
    public async Task ThenTheResponseEntityShouldBe(string file)
    {
        string path = GetJson(file);

        dynamic expected = null;
        dynamic actual = null;

        switch (file)
        {
            case "categories.json":
                expected = ObjectData<List<Category>>(path);
                actual = ObjectData<List<Category>>(JsonResponse);

                if (expected is List<Category> expCategoriesList && actual is List<Category> actualCategoriesList)
                    Assert.True(expCategoriesList.Select(x => x.Id).Intersect(actualCategoriesList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "category.json":
                expected = ObjectData<Category>(path);
                actual = ObjectData<Category>(JsonResponse);

                Assert.Equal(expected is Category expCategory ? expCategory.Id : Guid.Empty, actual is Category act ? act.Id : Guid.Empty);
                break;
            case "imageurls.json":
                expected = ObjectData<List<ImageUrl>>(path);
                actual = ObjectData<List<ImageUrl>>(JsonResponse);

                if (expected is List<ImageUrl> expImageUrlsList && actual is List<ImageUrl> actualImageUrlsList)
                    Assert.True(expImageUrlsList.Select(x => x.Id).Intersect(actualImageUrlsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "imageurl.json":
                expected = ObjectData<ImageUrl>(path);
                actual = ObjectData<ImageUrl>(JsonResponse);

                Assert.Equal(expected is ImageUrl expImageUrl ? expImageUrl.Id : Guid.Empty, actual is ImageUrl actImageUrl ? actImageUrl.Id : Guid.Empty);
                break;
            case "reviews.json":
                expected = ObjectData<List<Review>>(path);
                actual = ObjectData<List<Review>>(JsonResponse);

                if (expected is List<Review> expReviewsList && actual is List<Review> actualReviewsList)
                    Assert.True(expReviewsList.Select(x => x.Id).Intersect(actualReviewsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "review.json":
                expected = ObjectData<Review>(path);
                actual = ObjectData<Review>(JsonResponse);

                Assert.Equal(expected is Review expReview ? expReview.Id : Guid.Empty, actual is Review actReview ? actReview.Id : Guid.Empty);
                break;
            case "shops.json":
                expected = ObjectData<List<Shop>>(path);
                actual = ObjectData<List<Shop>>(JsonResponse);

                if (expected is List<Shop> expShopsList && actual is List<Shop> actualShopsList)
                    Assert.True(expShopsList.Select(x => x.Id).Intersect(actualShopsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "shop.json":
                expected = ObjectData<Shop>(path);
                actual = ObjectData<Shop>(JsonResponse);

                Assert.Equal(expected is Shop expShop ? expShop.Id : Guid.Empty, actual is Shop actShop ? actShop.Id : Guid.Empty);
                break;
            case "shopavatars.json":
                expected = ObjectData<List<ShopAvatar>>(path);
                actual = ObjectData<List<ShopAvatar>>(JsonResponse);

                if (expected is List<ShopAvatar> expShopAvatarsList && actual is List<ShopAvatar> actualShopAvatarsList)
                    Assert.True(expShopAvatarsList.Select(x => x.Id).Intersect(actualShopAvatarsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "shopavatar.json":
                expected = ObjectData<ShopAvatar>(path);
                actual = ObjectData<ShopAvatar>(JsonResponse);

                Assert.Equal(expected is ShopAvatar expShopAvatar ? expShopAvatar.Id : Guid.Empty, actual is ShopAvatar actShopAvatar ? actShopAvatar.Id : Guid.Empty);
                break;


            case "users.json":
                expected = ObjectData<List<User>>(path);
                actual = ObjectData<List<User>>(JsonResponse);

                if (expected is List<User> expUsersList && actual is List<User> actualUsersList)
                    Assert.True(expUsersList.Select(x => x.Id).Intersect(actualUsersList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "user.json":
                expected = ObjectData<User>(path);
                actual = ObjectData<User>(JsonResponse);

                Assert.Equal(expected is User expUser ? expUser.Id : string.Empty, actual is User actUser ? actUser.Id : string.Empty);
                break;

            default:
                break;
        }


    }

    [Given(@"the repository has '(.*)' data")]
    public async Task GivenTheRepositoryHasCategoryData(string endpoint)
    {
        Response = await Client.GetAsync($"{BaseAddress}{endpoint}");

        var response = await Response.Content.ReadAsStringAsync();

        JsonResponse = response.JsonPrettify();

        Assert.True(!string.IsNullOrEmpty(JsonResponse));
    }

    [Then(@"the response json should be '(.*)'")]
    public async Task ThenTheResponseDataShouldBe(string file)
    {
        var response = await Response.Content.ReadAsStringAsync();

        string path = GetJson(file);
        dynamic expected = null;
        dynamic actual = null;

        switch (file)
        {
            case "categories.json":
                expected = ObjectData<List<Category>>(path);
                actual = ObjectData<List<Category>>(response.JsonPrettify());

                if (expected is List<Category> expCategoriesList && actual is List<Category> actualCategoriesList)
                    Assert.True(expCategoriesList.Select(x => x.Id).Intersect(actualCategoriesList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "category.json":
                expected = ObjectData<Category>(path);
                actual = ObjectData<Category>(response.JsonPrettify());

                Assert.Equal(expected is Category expCategory ? expCategory.Id : Guid.Empty, actual is Category act ? act.Id : Guid.Empty);
                break;
            case "imageurls.json":
                expected = ObjectData<List<ImageUrl>>(path);
                actual = ObjectData<List<ImageUrl>>(response.JsonPrettify());

                if (expected is List<ImageUrl> expImageUrlsList && actual is List<ImageUrl> actualImageUrlsList)
                    Assert.True(expImageUrlsList.Select(x => x.Id).Intersect(actualImageUrlsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "imageurl.json":
                expected = ObjectData<ImageUrl>(path);
                actual = ObjectData<ImageUrl>(response.JsonPrettify());

                Assert.Equal(expected is ImageUrl expImageUrl ? expImageUrl.Id : Guid.Empty, actual is ImageUrl actImageUrl ? actImageUrl.Id : Guid.Empty);
                break;
            case "reviews.json":
                expected = ObjectData<List<Review>>(path);
                actual = ObjectData<List<Review>>(response.JsonPrettify());

                if (expected is List<Review> expReviewsList && actual is List<Review> actualReviewsList)
                    Assert.True(expReviewsList.Select(x => x.Id).Intersect(actualReviewsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "review.json":
                expected = ObjectData<Review>(path);
                actual = ObjectData<Review>(response.JsonPrettify());

                Assert.Equal(expected is Review expReview ? expReview.Id : Guid.Empty, actual is Review actReview ? actReview.Id : Guid.Empty);
                break;
            case "shops.json":
                expected = ObjectData<List<Shop>>(path);
                actual = ObjectData<List<Shop>>(response.JsonPrettify());

                if (expected is List<Shop> expShopsList && actual is List<Shop> actualShopsList)
                    Assert.True(expShopsList.Select(x => x.Id).Intersect(actualShopsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "shop.json":
                expected = ObjectData<Shop>(path);
                actual = ObjectData<Shop>(response.JsonPrettify());

                Assert.Equal(expected is Shop expShop ? expShop.Id : Guid.Empty, actual is Shop actShop ? actShop.Id : Guid.Empty);
                break;
            case "shopavatars.json":
                expected = ObjectData<List<ShopAvatar>>(path);
                actual = ObjectData<List<ShopAvatar>>(response.JsonPrettify());

                if (expected is List<ShopAvatar> expShopAvatarsList && actual is List<ShopAvatar> actualShopAvatarsList)
                    Assert.True(expShopAvatarsList.Select(x => x.Id).Intersect(actualShopAvatarsList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "shopavatar.json":
                expected = ObjectData<ShopAvatar>(path);
                actual = ObjectData<ShopAvatar>(response.JsonPrettify());

                Assert.Equal(expected is ShopAvatar expShopAvatar ? expShopAvatar.Id : Guid.Empty, actual is ShopAvatar actShopAvatar ? actShopAvatar.Id : Guid.Empty);
                break;


            case "users.json":
                expected = ObjectData<List<User>>(path);
                actual = ObjectData<List<User>>(response.JsonPrettify());

                if (expected is List<User> expUsersList && actual is List<User> actualUsersList)
                    Assert.True(expUsersList.Select(x => x.Id).Intersect(actualUsersList.Select(n => n.Id)).Any());
                else
                    Assert.True(false);

                break;
            case "user.json":
                expected = ObjectData<User>(path);
                actual = ObjectData<User>(response.JsonPrettify());

                Assert.Equal(expected is User expUser ? expUser.Id : string.Empty, actual is User actUser ? actUser.Id : string.Empty);
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