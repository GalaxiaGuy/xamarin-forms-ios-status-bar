**In Xamarin Forms on iOS, when popping a modal that has changed the status bar text color, it is not returned to the correct color.**

By default on iOS in Xamarin Forms, the status bar text color changes to be appropriate when setting `BarTextColor` on a 
navigation page. This change happens when bar text color is changed and when the navigation page is loaded. It does not 
happen when a modal is popped.
