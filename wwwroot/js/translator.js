function translateToLeetspeak(text) {
    // Create a new XMLHttpRequest object
    var xhr = new XMLHttpRequest();

    // Define the API endpoint URL
    var url = 'https://api.funtranslations.com/translate/leetspeak';

    // Set up the request
    xhr.open('POST', url, true);
   //xhr.setRequestHeader('Content-Type', 'application/json');

    // Set up the callback function for when the response is received
    xhr.onload = function () {
        if (xhr.status >= 200 && xhr.status < 300) {
            // Parse the JSON response
            var response = JSON.parse(xhr.responseText);
            // Display the translated text
            document.getElementById('translatedText').value = response.contents.translated;
        } else {
            // If request fails, log the error
            console.error('Request failed. Status:', xhr.status);
        }
    };

    // Set up error handling
    xhr.onerror = function () {
        console.error('Request failed. Network error.');
    };



	 var formData = new FormData();
    formData.append('text', text);

    xhr.send(formData);
   }



console.log("How are you doing`")
