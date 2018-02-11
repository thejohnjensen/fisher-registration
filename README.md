# fisher-registration
Registration service to protect undocumented workers.

# To run
Run this from anywhere
`npm install -g gulp`
Run this from the Fish-Registration project folder
`npm install`
`dotnet restore`
`dotnet run`

Note: If you make changes to the Styles/site.scss, you must kill the `dotnet run` process and restart it. The gulp task to compile SCSS to CSS only runs during build.

# Updating ApplicationUser class (or any EF model)
After you add new properties or update any existing ones, the EF model will need to be synced-up with the DB. You will need to add a new migration.
`dotnet ef migrations add <migration-name>`

Then run the update to the update the DB. Be sure to stop the application if it is running.
`dotnet ef database update`