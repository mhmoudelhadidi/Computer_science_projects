import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.PageFactory;
import org.testng.Assert;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;
import org.testng.asserts.SoftAssert;

public class TestCases
{


    WebDriver driver = null;
    //this is object is like my mouse
    // and keyboard on the website that will
    // be tested or automated



    //Four objects of the classes
    RegistrationPage registrationPage;
    LoginPage loginPage;
    ResetPage resetPage;
    AddProductToShoppingCartPage addProductPage;



    @BeforeMethod
    public void OpenBrowser()throws InterruptedException
    {
        // 1- bridge between test scripts and browsers
        String chromePath =System.getProperty("user.dir") + "\\src\\main\\resources\\chromedriver.exe";

        //just to make sure
        System.out.println(chromePath);


        // String chromepath = System.getProperty("user.dir") + "\\chromedriver-win32\\chromedriver-win32\\chromedriver.exe" ;
        System.setProperty("webdriver.chrome.driver",chromePath);

        // 2- New object of WebDriver
        driver = new ChromeDriver();
//
        // 3- Navigate to google website and maximize screen and sleep 3 second
        driver.navigate().to("https://demo.nopcommerce.com/");
        driver.manage().window().maximize();

        Thread.sleep(2000);
    }

    @Test
    public void Register() throws InterruptedException
    {
        driver.navigate().to("https://demo.nopcommerce.com/");



        // Click on the "Register" link
        //POM design pattern
        //object and using PageFactory.initElements
        //this obj will passed to the constructor
        //it is optimally done in the constructor

        registrationPage = PageFactory.initElements(driver, RegistrationPage.class);

        //or

        //registrationPage = PageFactory.initElements(driver, this);


        registrationPage.clickRegisterLink();


        //The old way
        //THE OLD WAY
//        driver.navigate().to("https://www.saucedemo.com/");
//        driver.findElement(By.id("user-name")).clear()  ;
//        driver.findElement(By.id("user-name")).sendKeys("standard_user") ;
//        driver.findElement(By.name("password")).sendKeys("secret_sauce") ;
//        //this is instead of login button when click on the password box will enter to
//        //the login tab
//        driver.findElement(By.name("password")).sendKeys(Keys.ENTER) ;
//
//
//
//        System.out.println("First assertion successfully");
//        //First Assertion for URL after you log in
//        Assert.assertEquals(driver.getCurrentUrl() , "https://www.saucedemo.com/inventory.html");
//

        // Fill in registration form


        registrationPage.selectMaleGender(); //this is method of the class
        registrationPage.enterFirstName("Mohamed"); //this is method of the class
        registrationPage.enterLastName("Tharwat");  //this is method of the class
        registrationPage.selectDateOfBirth("21","3","2003");
        //you must use new email every time
        registrationPage.enterEmail("hrtanifggffdmohemadthrwat339@gmail.com");
        registrationPage.enterCompany("softmax");
        registrationPage.enterPassword("123456789");
        registrationPage.enterConfirmPassword("123456789");
        registrationPage.clickRegisterButton();


        // Soft Assertion
        SoftAssert soft = new SoftAssert();
//
//        // First Assertion       Your registration completed
        String expectedResult = "Your registration completed";
        String actualResult = registrationPage.getRegistrationResult();

        System.out.println("first assertion");
        soft.assertTrue(actualResult.contains(expectedResult), "first Assertion in Register");

//
//
////        // Second Assertion
//
//
        soft.assertEquals(driver.getCurrentUrl(), "https://demo.nopcommerce.com/registerresult/1?returnUrl=/", "Second Assertion in Register");

        // Assert All
        soft.assertAll(); //it must be write to mark it of the hard assertion using driver
        Thread.sleep(2000);
    }


    @Test
    public void LoginWithValidData() throws InterruptedException
    {

        //to run individual test case
        driver.navigate().to("https://demo.nopcommerce.com/");

        loginPage = new LoginPage(driver); //take object
        loginPage.clickLoginLink();
        loginPage.enterEmail("mohemadthrwat339@gmail.com");
        loginPage.enterPassword("123456789");

        // Soft Assertion
        SoftAssert soft = new SoftAssert();

        // First Assertion
        //You are already logged in as Mohamed Tharwat. You may log in with another account.
        String expectedResult = "My account is logged successfully";
        String actualResult = loginPage.getAccountIconText() + " is logged successfully";
        soft.assertTrue(actualResult.contains(expectedResult), "First Assertion in Valid Data");

//        // Second Assertion

        soft.assertEquals(driver.getCurrentUrl(), "https://demo.nopcommerce.com/" , "Second Assertion in Valid Data");
//
//        // Assert All
        soft.assertAll();
        Thread.sleep(3000);
    }


    @Test
    public void LoginWithInValidData() throws InterruptedException
    {
        //to run individual test case
        driver.navigate().to("https://demo.nopcommerce.com/");

        loginPage = new LoginPage(driver);
        loginPage.clickLoginLink();
        loginPage.enterEmail("iron@std.mans.edu.eg");
        loginPage.enterPassword("67890");

        // Soft Assertion
        SoftAssert soft = new SoftAssert();

        // First Assertion
        String expectedResult = "Login was unsuccessful. Please correct the errors and try again.\n" + "No customer account found";
        String actualResult = loginPage.getErrorMessageText();
        soft.assertTrue(actualResult.contains(expectedResult), "First Assertion in Invalid data");

        // Second Assertion
        soft.assertEquals(driver.getCurrentUrl(), "https://demo.nopcommerce.com/login?returnurl=%2F", "Second Assertion in Invalid data");

        // Assert All
        soft.assertAll();
        Thread.sleep(3000);
    }

    private void extracted() {
        loginPage = new LoginPage(driver);
        loginPage.clickLoginLink();
    }

    @Test
    public void ResetWithValidData() throws InterruptedException
    {
        //to run individual test case
        driver.navigate().to("https://demo.nopcommerce.com/");


        resetPage = new ResetPage(driver);
        resetPage.goToLoginPage();
        resetPage.goToForgotPasswordPage();
        resetPage.enterEmail("mohemadthrwat339@gmail.com");

        SoftAssert soft = new SoftAssert();
        String expectedResult = "Email with instructions has been sent to you.";
        String actualResult = resetPage.getContentText();

        soft.assertTrue(actualResult.contains(expectedResult), "Assertion failed.");

        soft.assertAll();
        Thread.sleep(3000);
    }

    @Test
    public void ResetWithInvalidData() throws InterruptedException
    {
        //to run individual test case
        driver.navigate().to("https://demo.nopcommerce.com/");


        resetPage = new ResetPage(driver);
        resetPage.goToLoginPage();
        resetPage.goToForgotPasswordPage();
        resetPage.enterEmail("iron@std.mans.edu.eg");

        SoftAssert soft = new SoftAssert();
        String expectedResult = "Email not found.";
        String actualResult = resetPage.getContentText();
        soft.assertTrue(actualResult.contains(expectedResult), "Assertion failed.");
        soft.assertAll();
        Thread.sleep(3000);
    }

    @Test
    public void AddProductToShoppingCart() throws InterruptedException
    {

        //to run individual test case
       // driver.navigate().to("https://demo.nopcommerce.com/");

        addProductPage = new AddProductToShoppingCartPage(driver);
        addProductPage.clickOnProductLink();
        addProductPage.addToCart();

        //Whhhhhhyyy
       //addProductPage.goToShoppingCart();

        // Soft Assertion
        SoftAssert soft = new SoftAssert();

        // First Assertion
        String expectedResult = "The product has been added to your shopping cart";
        String actualResult = addProductPage.getMessage();
//        System.out.println(actualResult);


        soft.assertTrue(actualResult.contains(expectedResult), "Assertion Passed Successfully Akheern");



//        // First Assertion
//        String expectedResult = "HTC One M8 Android L 5.0 Lollipop";
//        String actualResult = addProductPage.getProductName();
//        soft.assertTrue(actualResult.contains(expectedResult),
//                "An error occurred while adding the product to the shopping cart.");
        // Assert All
        soft.assertAll();
        Thread.sleep(2000);
    }

    @AfterMethod
    public void CloseDriver()
    {
//        driver.quit();
    }
}