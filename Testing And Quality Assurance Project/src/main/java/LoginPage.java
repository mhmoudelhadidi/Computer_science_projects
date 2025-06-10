import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

public class LoginPage {
    WebDriver driver;

    //constructor
    public LoginPage(WebDriver driver) {
        this.driver = driver;

        //i did it in the constructor
        PageFactory.initElements(driver, this);
    }

    @FindBy( linkText = "Log in")
    private WebElement loginLink;

    @FindBy(id = "Email")
    private WebElement emailInput;


    @FindBy(name = "Password")
    private WebElement passwordInput;



    @FindBy(className = "ico-account")
    private WebElement accountIcon;




    @FindBy(className = "message-error")
    private WebElement errorMessage;





    //to be used each time
    public void navigateToLoginPage() {
        this.driver.navigate().to("https://demo.nopcommerce.com/");
        this.driver.manage().window().maximize();
    }

    public void clickLoginLink() {
        this.loginLink.click();
    }

    public void enterEmail(String email) {
        this.emailInput.clear();
        this.emailInput.sendKeys(new CharSequence[]{email});
    }

    public void enterPassword(String password) {
        this.passwordInput.sendKeys(new CharSequence[]{password});
        this.passwordInput.sendKeys(new CharSequence[]{Keys.ENTER});
    }

    public String getAccountIconText() {
        return this.accountIcon.getText();
    }

    public String getErrorMessageText() {
        return this.errorMessage.getText();
    }
}
