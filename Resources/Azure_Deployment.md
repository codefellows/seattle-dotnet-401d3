# Azure Deployment

## Deploying a Web App...

1. Right click on the solution and select publish OR Select "Build" from your navigation and select "Publish"

1. You will be prompted to either create a new profile, or select an existing. if this is the first time you are publishing, then create new.
1. Select Publish at the bottom right

1.  you will be presented with another screen to set the details up for your deployment. Make sure the account on the top right corner is the same
as the account you registered Azure with.
1. Change your appname to whatever you wish. 
1. Confirm your subscription (it is likely yours will be different, likely "pay as you go")
1. Select your resource group
1. Select create

After you select create, your app is going to go into a "publish" mode. Let it finish it's processing

1. After the processing is complete, you will receive a confirmation with all the information about your deployment. 

## Azure Settings

1. Log into your Azure portal (portal.azure.com) and you will see your newly deployed application in your list of App Services

### Adding a Database

1. Select SQL databases from the blade menu on the lefthand side. 
1. "Add" a new database
1. Fill out the form with all the approraite information about your database and your sql server. 
1. Select your Pricing Tier. **Select Basic tier and apply**
1. After craeting your database, and after it has been deployed, you can now view your database in your Sql Database list.
1. Select your database and an overview screen will appear.From here you obtain your connection string and other relevant information about your database

## Connecting your app to your DB

1. Grab your connection string, and fill in your server usrname and password. 
1. Copy/paste that into your appsettings.json file in our web application. This should be a new connection string.
1. Make sure the name of the connection string matches the name of the database connection string you defined in your startup.cs file. 
1. run an `Update-Database` command in your package manager console to update your production database. 

