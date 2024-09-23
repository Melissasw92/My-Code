#include <stdio.h>   // Provides input/output functions
#include <string.h>  // Provides string manipulation functions

// Define constants for clothing item prices using macros
#define SHIRT_PRICE 19.99
#define SHOE_PRICE 49.99
#define PANTS_PRICE 29.99

#define USA_STANDARD_SHIPPING 5.99
#define USA_EXPEDITED_SHIPPING 9.99
#define MEXICO_STANDARD_SHIPPING 7.99
#define MEXICAN_EXPEDITED_SHIPPING 12.99
#define CANADA_STANDARD_SHIPPING 6.99
#define CANADA_EXPEDITED_SHIPPING 11.99

#define USA_TAX_RATE 0.08
#define MEXICO_TAX_RATE 0.16
#define CANADA_TAX_RATE 0.12

int main(void) {
    // Declare variables
    char userInput[20];  // Array to store user input for clothing type
    int shirtQuantity = 0, shoeQuantity = 0, pantsQuantity = 0;  // Variables to store quantities of each clothing item
    char itemInput[20];
    char countryinput[20];
    char *countryinput1 = "USA";
    char shippinginput[20];
    char *shippinginput1 = "Standard";
    float totalcost = 0.0, shippingcost = 0.0, taxrate = 0.0;

   
    do {
        // Display menu options to the user
        int quantity = 0;

        printf("Enter the type of clothing needed (shirt, shoes, pants).\n");
        printf("Type 'exit' to quit and proceed to shipping details.\n");
        scanf("%s", itemInput);

        if (strcmp(itemInput, "exit") == 0) {
        break;
        }
        
        switch (itemInput[2]) {
            case 'i':
            if (strcmp(itemInput, "shirt") ==0) {
                printf("Enter the quantity of %ss needed: Clothing item '%s' successfully added to your cart.\n", itemInput, itemInput);
                scanf("%d", &quantity);
                shirtQuantity += quantity;
                break; 
            }
            
            case 'o':
            if (strcmp(itemInput, "shoes") == 0) {
                printf("Enter the quantity of %s needed: Clothing item '%s' successfully added to your cart.\n", itemInput, itemInput);
                scanf("%d", &quantity);
                shoeQuantity += quantity;
                break;
            }
                case 'n':
                if (strcmp(itemInput, "pants") ==0) {
                    printf("Enter the quantity of %s needed: Clothing item '%s' successfully added to your cart.\n", itemInput, itemInput);
                    scanf("%d", &quantity);
                    pantsQuantity += quantity;
                    break;
                }
            default:
                printf("Invalid clothing type. Please enter 'shirt', 'shoes', or 'pants'.\n");
               
                if (strcmp(userInput, "exit") == 0) {
                }
                break;
            }  
            

   
     } while (1);

    
    printf("\nEnter the shipping destination (USA, Mexico, Canada): ");
    scanf("%s", countryinput);
    printf("Enter the shipping method (standard, expedited): ");
    scanf("%s", shippinginput);

    
    if (strcasecmp(countryinput, "USA") == 0) {
        taxrate = USA_TAX_RATE;
        if (strcasecmp(shippinginput, "standard") == 0) {
            shippingcost = USA_STANDARD_SHIPPING;
            countryinput1 = "USA";
        } else if (strcasecmp(shippinginput, "expedited") == 0) {
            shippingcost = USA_EXPEDITED_SHIPPING;
            countryinput1 = "USA";
            shippinginput1 = "Expedited";
        }
    } else if (strcasecmp(countryinput, "Mexico") == 0) {
        taxrate = MEXICO_TAX_RATE;
        if (strcasecmp(shippinginput, "standard") == 0) {
            shippingcost = MEXICO_STANDARD_SHIPPING;
            countryinput1 = "Mexico";
        } else if (strcasecmp(shippinginput, "expedited") == 0) {
            shippingcost = MEXICAN_EXPEDITED_SHIPPING;
        countryinput1 = "Mexico";
        shippinginput1 = "Expedited";
        }
    } else if (strcasecmp(countryinput, "Canada") == 0) {
        taxrate = CANADA_TAX_RATE;
        if (strcasecmp(shippinginput, "standard") == 0) {
            shippingcost = CANADA_STANDARD_SHIPPING;
            countryinput1 = "Canada";
        } else if (strcasecmp(shippinginput, "expedited") == 0) {
            shippingcost = CANADA_EXPEDITED_SHIPPING;
            countryinput1 = "Canada";
            shippinginput1 = "Expedited";
            
        }

    } else {
        printf("Invalid shipping destination. Defaulting to USA standard shipping.\n");
        shippingcost = USA_STANDARD_SHIPPING;
        taxrate = USA_TAX_RATE;
        countryinput1 = "USA";
        shippinginput1 = "Standard";
    }
    float Subtotal = (shirtQuantity * SHIRT_PRICE) + (shoeQuantity * SHOE_PRICE) + (pantsQuantity * PANTS_PRICE);

    
    printf("\nClothing Item\tQuantity\tPrice\t\tTotal\n");
    printf("-------------------------------------------------------\n");
    printf("Shirts\t\t%d\t\t$%.2f\t\t$%.2f\n", shirtQuantity, SHIRT_PRICE, (shirtQuantity * SHIRT_PRICE));
    printf("Shoes\t\t%d\t\t$%.2f\t\t$%.2f\n", shoeQuantity, SHOE_PRICE, (shoeQuantity * SHOE_PRICE));
    printf("Pants\t\t%d\t\t$%.2f\t\t$%.2f\n", pantsQuantity, PANTS_PRICE, (pantsQuantity * PANTS_PRICE));
    printf("-------------------------------------------------------\n");
    printf("Subtotal:\t\t\t\t\t$%.2f\n", Subtotal);
    printf("Shipping Destination: %s\n", countryinput1);
    printf("Shipping Method: %s to %s\n", shippinginput1, countryinput1);
    printf("Shipping Cost:					$%.2f\n", shippingcost);
    printf("Tax (%.2f%%):					$%.2f\n", taxrate * 100, taxrate * Subtotal);
    printf("-------------------------------------------------------\n");
    printf("Total Cost (including tax and shipping):	$%.2f\n", Subtotal + shippingcost + (taxrate * Subtotal));


    return 0;  // Indicate successful program execution

}

