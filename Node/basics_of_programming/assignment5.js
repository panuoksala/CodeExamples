// Avain: NDDgQs9wqm157eWRT0hiG9Y7QYS1InAW96siuGnQ
// Header: x-api-key
// 74 is Sähköntuotanto Suomessa
// https://data.fingrid.fi/fi/dataset/electricity-production-in-finland
const https = require('node:https');

// Create two variables, which are todays start time and endtime. 
const startToday = new Date(new Date().setUTCHours(0,0,0,0));
let endToday = new Date();

// This is a bit magic, but what we are doing here is to create variable called
// queryParams, which has two variables: start_time and end_time. Both are dates as toISOString().
// However toISOString() has a problem that it contains time in milliseconds and the Findgrid API don't allow that
// Whats why we are using some regexp magic to remove the milliseconds from the end.

const queryParams = { start_time: startToday.toISOString().replace(/.\d+Z$/g, "Z"), end_time: endToday.toISOString().replace(/.\d+Z$/g, "Z") }
// Lets build query parameters in URL encoded format, because have characters like T and Z in our query parameters.
const queryString = new URLSearchParams(queryParams).toString()

// Build options to make API call
const options = {
    hostname: 'api.fingrid.fi',
    path: '/v1/variable/74/events/json?' + queryString,
    method: 'GET',
    headers: {
        'x-api-key': 'NDDgQs9wqm157eWRT0hiG9Y7QYS1InAW96siuGnQ',
        'Accept': 'application/json'
    }
};

// Make the actual request into server
const req = https.request(options, (response) => {
    // Log what response we had
    console.log('statusCode:', response.statusCode);
    // Set encoding to handle response parsing into string
    response.setEncoding('utf8');
    response.on('data', function (body) {
        // Print body as sample
        console.log(body);
        // Body is now string, so we can build object from the string (deserialize) and start doing cool stuff with it
        var responseObject = JSON.parse(body);
        // First object in the array
        console.log(responseObject[0]);
        // First object value in the array
        console.log(responseObject[0].value);
      });
});

// If we had error, log that
req.on('error', (e) => {
    console.error(e);
  });
  
// Close the stream
req.end();