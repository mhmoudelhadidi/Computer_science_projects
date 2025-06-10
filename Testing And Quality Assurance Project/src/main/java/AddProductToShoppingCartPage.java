import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

public class AddProductToShoppingCartPage {

    private WebDriver driver;
    public AddProductToShoppingCartPage(WebDriver driver) {
        this.driver = driver;
        PageFactory.initElements(driver, this);
    }

    @FindBy(linkText = "HTC One M8 Android L 5.0 Lollipop")
    private WebElement productLink;

    @FindBy(id = "add-to-cart-button-18")
    private WebElement addToCartButton;

    @FindBy(linkText = "Shopping cart")
    private WebElement shoppingCartLink;

    @FindBy(className = "product-title")
    private WebElement productName;


    //Focus Here
    //this is MOTHARWAT

    //bar-notification success
    @FindBy(className= "content")
    private WebElement message;




    public void clickOnProductLink() {
        productLink.click();
    }

    public void addToCart() {
        addToCartButton.click();
    }

    public void goToShoppingCart() {
        shoppingCartLink.click();
    }

    public String getProductName() {
        return productName.getText();
    }


    //This is very important
    public String getMessage() {
        return message.getText();
    }
}
