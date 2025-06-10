import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.ui.Select;
public class RegistrationPage {
    WebDriver driver; //mouse and keyboard


    //Constructor
    public RegistrationPage(WebDriver driver) {
        this.driver = driver; //as it must be the same driver
    }


    @FindBy(linkText = "Register")     //instead of function
    private WebElement registerLink;  //this what i will use in the method


    @FindBy(id = "gender-male")
    private WebElement maleGenderRadioButton;



    //the old way before design pattern
    //the old way before design pattern


//    //Apply POM using BY method
//    public By usernamePOM(){
//
//        return By.id("gender-male")  ;
//    }
//
//    public WebElement maleGenderRadioButton1(WebElement driver){
//
//        //POM Design Pattern
//        By username = By.id("gender-male") ;
//        //driver.findElement(By.id("user-name")) this is called web element
//        WebElement usernameElement = driver.findElement(username) ;
//
//        return usernameElement ;
//
//        //just one line
//        return driver.findElement(By.id("gender-male")) ;
//    }




    @FindBy(id = "FirstName")
    private WebElement firstNameInput;

    @FindBy(id = "LastName")
    private WebElement lastNameInput;

    @FindBy(name = "DateOfBirthDay")
    private WebElement dayOfBirthDropdown;

    @FindBy(name = "DateOfBirthMonth")
    private WebElement monthOfBirthDropdown;

    @FindBy(name = "DateOfBirthYear")
    private WebElement yearOfBirthDropdown;

    @FindBy(id = "Email")
    private WebElement emailInput;

    @FindBy(id = "Company")
    private WebElement companyInput;

    @FindBy(id = "Password")
    private WebElement passwordInput;

    @FindBy(id = "ConfirmPassword")
    private WebElement confirmPasswordInput;

    @FindBy(id = "register-button")
    private WebElement registerButton;

    @FindBy(className = "result")
    private WebElement registrationResult;






    //these methods selects the previous locators
    public void clickRegisterLink() {
        registerLink.click();
    }

    public void selectMaleGender() {
        maleGenderRadioButton.click();
    }

    public void enterFirstName(String firstName) {
        firstNameInput.sendKeys(firstName);
    }

    public void enterLastName(String lastName) {
        lastNameInput.sendKeys(lastName);
    }

//    It uses the ..Select class.. to interact with dropdown elements (dayOfBirthDropdown, monthOfBirthDropdown, and yearOfBirthDropdown).
//    It selects values from these dropdowns based on the provided day, month, and year values.
    public void selectDateOfBirth(String day, String month, String year) {
        new Select(dayOfBirthDropdown).selectByValue(day); //put  day  in  dayOfBirthDropdown and assert
        new Select(monthOfBirthDropdown).selectByValue(month);
        new Select(yearOfBirthDropdown).selectByValue(year);
    }

    public void enterEmail(String email) {
        emailInput.sendKeys(email);
    }

    public void enterCompany(String company) {
        companyInput.sendKeys(company);
    }

    public void enterPassword(String password) {
        passwordInput.sendKeys(password);
    }

    public void enterConfirmPassword(String confirmPassword) {
        confirmPasswordInput.sendKeys(confirmPassword);
    }

    public void clickRegisterButton() {
        registerButton.click();
    }

    public String getRegistrationResult() {
        return registrationResult.getText();
    }
}
