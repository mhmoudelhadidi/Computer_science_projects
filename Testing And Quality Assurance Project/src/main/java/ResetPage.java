import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

public class ResetPage {

    WebDriver driver;

    public ResetPage(WebDriver driver)
    {
        this.driver = driver;
        PageFactory.initElements(driver, this);
    }

    @FindBy(linkText = "Log in")
    private WebElement loginLink;

    @FindBy(linkText = "Forgot password?")
    private WebElement forgotPasswordLink;

    @FindBy(id = "Email")
    private WebElement emailField;

    @FindBy(className = "content")
    private WebElement contentText;



    public void goToLoginPage() {
        loginLink.click();
    }


    public void goToForgotPasswordPage() {
        forgotPasswordLink.click();
    }


    public void enterEmail(String email) {
        emailField.clear();
        emailField.sendKeys(email);
        emailField.sendKeys(Keys.ENTER);
    }

    public String getContentText() {
        return contentText.getText();
    }
}
