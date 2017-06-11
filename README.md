# ProjectSkroutz
Our aim is to develop a website similar to skroutz.gr (or scrooge.co.uk) limited to technology products.  Development of the website should start from an empty MVC project and will be separated into phases of advancing difficulty and complexity.  Skroutz - Phase A  In Phase A, we only have products, categories and stores. Categories can have hierarchy, a product has only one category, and a store can sell many products and a product can be sold in many stores with different price.  Create the model. Populate the database with seed data (c/p from original website if you like). Implement a Data Access Layer (DAL) exposing methods for common database actions. Create controllers and views for viewing/inserting/editing/deleting the model. Categories:  Computers Hardware Monitors Entertainment Televisions &amp; Accessories Projectors &amp; Accessories Gaming Consoles Virtual Reality Skroutz - Phase B  Every product has attributes. Products of the same category have the same attribute definitions, but different attribute values.  Extend the model. Populate the database (not all attributes are needed, but at least those that scrooge.co.uk uses for filtering). Update the controllers and views. Skroutz - Phase C  After inserting enough entries to the model, continue with the design of the main website. It should be similar to original website:  Home page with full-screen section for search, boxes of categories. Each category has its own page with boxes of subcategories. Categories with no children lead to list of products. (No filters for now) Page of product displaying details, list of stores etc.
