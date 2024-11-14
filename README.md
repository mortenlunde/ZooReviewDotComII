# ZooReviewDotCom

**Blazor Web Application with MySQL Database**  
*Author: Morten Lunde @ 2024*

---

## Table of Contents
- [Project Overview](#project-overview)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Authentication & Authourization](#authentication--authourization)
- [Online Status](#online-status)

---

## Project Overview
**ZooReviewDotCom** is a web application built using Blazor that allows users to view and leave reviews on different 
zoos. The project includes authentication, a rating system, and sorting options to improve user experience. It uses a 
MySQL database to store reviews and user information, offering a robust platform for managing zoo-related content.

## Technologies Used
- **Frontend**: Blazor Server
- **Backend**: .Net 8.0
- **Database**: MySQL
- **Styling**: BlazorBootstrap, custom CSS
- **Authentication**: Custom Basic Authentication
- **Cloud Services**: Azure

## Features
- **Zoo Reviews**: Users can view and add reviews for zoos, with ratings and comments.
- **Sorting**: Sort reviews by date, rating, or zoo name.
- **Pagination**: Allows easy navigation through a large number of reviews.
- **Authentication**: Basic authentication for access control.
- **Responsive Design**: User interface adapts to various device sizes.

## Authentication & Authourization
### 1. **Administrator**
- Only administrator can add, edit or delete zoo's. Users or visitors can not see the controls for this.
- Administrators can delete reviws, but not edit.

### 2. **Users**
- Can add, edit or delete their reviews. Only their own, not others. Controls is only visible if the correct user for
the action is logged in.
- All new users is getting the role as User in the system.

## Online Status
The project is deployed online to [Azure](http://zooreview-a5b0geesggawd8br.norwayeast-01.azurewebsites.net). The 
database is hosted at Domene.Shop.
