The program allows an employee of a rental car agency to create an inventory of cars and manage them. The application allow the employee to find cars, manage cars, and create a rental transaction for a customer.
1.	Implement the MVC Design Pattern:
2.	A form to allow the employee to add cars to the inventory:
a)	The new car form has controls to allow the user to enter information for a car that will be added to the rental agency’s inventory of cars. This form  add a new car to a collection of cars managed by the application. 
b)	Form controls for the user to enter the car’s category (economy, luxury, sport, SUV, van, pickup, etc…), car manufacturer, model of car, year, mileage, rental cost per day, availability (rented or available), description, location on the lot (parking spot), and an image.
c)	A drop-down box or radio button group to allow the user to select the car’s category.
d)	The product’s image  simply involve a string containing the URL of an image on the Web. Using: PictureBox.Load(theUrlString); 
e)	A button to allow the user to store the new car in the inventory. The store operation will involve creating an object that represents a car with the form data and store the item in a collection managed by the program. 
f)	A button to allow the user to view all cars in their inventory. This button should redirect the user to a form that contains search tools and controls that display the list of cars and information for them.

3.	A rental car display form: 
a)	This form allow a user to view the entire inventory of rental cars and the cars’ information. The items that are displayed come from the collection of cars managed by this application.
b)	Allow the user to view all cars in the inventory. Display summary information like the car manufacturer, model of car, category, availability, and price per day. The detailed information for the car displayed when a user selects a car from the list and chooses to see more detailed information for the car. 
i.	A ListView control with multiple columns to handle the car inventory list display.
ii.	When the user selects a car from the car inventory list, the program display all the information for that car including the image using a different set of form controls. 
c)	The form contain a search tool that allows the user to select a car based on the category, find all cars that match the criteria and are still available for rent, and display the cars along with their summary information. 

4.	Save & Restore the rental car inventory:
a)	When the program exits, the program  save the car inventory (collection of cars) to a text file.
b)	When the program starts, the program use the previously save text file to create the rental car inventory with all the cars and their information. If the text file doesn’t exist, then it create an empty collection. 

5.	Rent a car: 
a)	Allow the user to rent a car and record the transaction.
i.	Allow the user to enter customer information like contact information, driver license information, and insurance information.
ii.	Allow the user to select a car they wish to rent and the number of days for the rental.
iii.	Create a rental transaction object that contains all the customer information, the current date of the rental, the current time for the rental, cost, etc….
iv.	Calculate the total cost for the rental with tax and display a receipt for the rental transaction on a separate form. The receipt should include the car the user selected for rental, subtotal before tax, tax amount, and the total cost.
6.	Return a car:
a)	Allow the user to return a car, which changes the car’s availability.
b)	Allow the user the ability to note any damage found and update the mileage of the car.
