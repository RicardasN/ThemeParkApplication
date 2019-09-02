# ThemeParkApplication
This is my .Net Core project of a fictional Theme Park Website

FrontEnd is basic Bootstrap as it was created before I took the Web Developer Bootcamp Course and did not have any experience doing websites whatsover.
So as this was the very first proper website I created it's not amazing, but it has some features, like CRUD actions for the Attractions
and an ability to close/open them, which automatically informs all system users about the change. User roles are also implemented, alowing admin 
to have more control over the content on the website than the regular user. Database service used -MySql (MariaDB).
There's also Dependecy Injections and MockDbContext classes - using a regular list instead of modyfing DB data, this is mainly for testing purposes, so we wouldn't corrupt the possibly important information already stored in DB.
