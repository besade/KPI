# **Sweet Shop - Lab2 - Use Cases**
![UCD](../Diagram/Use_Case_Diagram.png)
---
## **Functional and Non-Functional Requirements**
### **Functional Requirements**

### **Non-Functional Requirements**
232
---
## PLANTUML Declaration
```plantuml
@startuml
left to right direction
skinparam usecase {
  BackgroundColor #FDF6E3
  BorderColor #657B83
  ArrowColor #586E75
  ActorBorderColor black
  ActorFontColor black
  UsecaseFontColor black
}

actor Customer
actor "Shop Manager" as Manager

' === CUSTOMER USE CASES ===
Customer --> (View Profile)
Customer --> (View Products)
Customer --> (Check Cart)
Customer --> (Make Order)
Customer --> (Make Product Review)
Customer --> (Check Orders History)

(View Profile) --> (Add Address) : <<use>>
(View Profile) --> (Delete Address) : <<extends>>
(View Profile) --> (Change Personal Information) : <<extends>>
(View Profile) --> (Complete Registration) : <<extends>>

(Complete Registration) --> (Add Personal Information) : <<extends>>
(Complete Registration) --> (Add Address) : <<use>>

(View Products) --> (View Catalogs) : <<extends>>
(View Products) --> (Find Products by Name) : <<extends>>
(View Products) --> (Add Item to Cart) : <<extends>>

(Add Item to Cart) --> (Change Cart Item Quantity) : <<use>>
(Add Item to Cart) --> (Delete Item from Cart) : <<use>>
(Add Item to Cart) --> (Delete All Cart Items) : <<use>>

(Check Cart) --> (Delete Item from Cart) : <<extends>>
(Check Cart) --> (Add Item to Cart) : <<use>>
(Check Cart) --> (Change Cart Item Quantity) : <<use>>
(Check Cart) --> (Delete All Cart Items) : <<use>>
(Check Cart) --> (Check Stock) : <<use>>

(Make Order) --> (Check Cart) : <<use>>
(Make Order) --> (Change Recipient Information) : <<extends>>
(Make Order) --> (Choose Address) : <<use>>
(Make Order) --> (Submit Order) : <<extends>>

(Submit Order) --> (Submit Payment) : <<use>>
(Submit Order) --> (Check Stock) : <<use>>

(Make Product Review) --> (View Products) : <<use>>
(Check Orders History) --> (Make Product Review) : <<use>>


' === SHOP MANAGER USE CASES ===
Manager --> (Manage Products)
Manager --> (Manage Catalogs)
Manager --> (Check Stock)
Manager --> (View Orders)
Manager --> (Check Reviews)

(Manage Products) --> (Add Product) : <<extends>>
(Manage Products) --> (Edit Product) : <<extends>>
(Manage Products) --> (Delete Product) : <<extends>>
(Manage Products) --> (Update Stock) : <<use>>

(Manage Catalogs) --> (Add Catalog) : <<extends>>
(Manage Catalogs) --> (Edit Catalog) : <<extends>>
(Manage Catalogs) --> (Delete Catalog) : <<extends>>

(View Orders) --> (Update Order Status) : <<extends>>
(View Orders) --> (Check Stock) : <<use>>

(Check Reviews) --> (Make Product Review) : <<use>>
(Check Stock) --> (View Products) : <<use>>

' === SHARED USE CASES ===
Customer --> (Check Stock)
Manager --> (Check Stock)

@enduml
```
## **Requirements**
1. ** Customer must be able to register and manage their profile**
2. ** Customer must be able to browse and search products**
3. ** Customer must be able to manage shopping cart**
4. ** Customer must be able to make and pay for orders, make reviews**
5. ** Administrator must be able to manage products, catalogs and stock**
6. ** Administrator must be able to view and update customer orders, view customer reviews**
---
## **Requirements Traceability Matrix**
| Use Case ↓ / Requirement →   | R1 | R2 | R3 | R4 | R5 | R6 |
|------------------------------|----|----|----|----|----|----|
| Add Address                  | ✅ |    |    |    |    |    |
| Add Catalog                  |   |    |    |    | ✅ |    |
| Add Item to Cart             |   |    | ✅ |    |    |    |
| Add Personal Information     | ✅ |    |    |    |    |    |
| Add Product                  |   |    |    |    | ✅ |    |
| Change Cart Item Quantity    |   |    | ✅ |    |    |    |
| Change Personal Information  | ✅ |    |    |    |    |    |
| Change Recipient Information |   |    |    | ✅ |    |    |
| Check Cart                   |   |    | ✅ |    |    |    |
| Change Personal Information  | ✅ |    |    |    |    |    |
| Check Orders History         | ✅ |    |    |    |    |    |
| Check Reviews                |   |    |    |    |    | ✅ |
| Check Stock                  |   |    |    | ✅ | ✅ |    |
| Choose Address               | ✅ |    |    | ✅ |    |    |
| Complete Registration        | ✅ |    |    |    |    |    |
| Delete Address               | ✅ |    |    |    |    |    |
| Delete All Cart Items        |   |    | ✅ |    |    |    |
| Delete Catalog               |   |    |    |    | ✅ |    |
| Delete Item from Cart        |   |    | ✅ |    |    |    |
| Delete Product               |   |    |    |    | ✅ |    |
| Edit Catalog                 |   |    |    |    | ✅ |    |
| Edit Product                 |   |    |    |    | ✅ |    |
| Find Products by Name        |   | ✅ |    |    |    |    |
| Make Order                   |   |    |    | ✅ |    |    |
| Make Product Review          |   |    |    | ✅ |    |    |
| Manage Catalogs              |   |    |    |    | ✅ |    |
| Manage Products              |   |    |    |    | ✅ |    |
| Submit Order                 |   |    |    | ✅ |    | ✅ |
| Submit Payment               |   |    |    | ✅ |    |    |
| Update Order Status          |   |    |    |    |    | ✅ |
| Update Stock                 |   |    |    | ✅ | ✅ |    |
| View Catalogs                |   |    | ✅ |    |    |    |
| View Orders                  |   |    |    |    |    | ✅ |
| View Products                |   | ✅ |    |    |    |    |
| View Profile                 | ✅ |    |    |    |    |    |
---


