BMI Calculator API
============

BMI Calculator is a simple tool for calculating body mass index. It returns the calculated BMI based on the weight and height provided.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [BMI Calculator API](https://apiverve.com/marketplace/api/bmicalculator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.BMICalculator
```

Using the Package Manager:
```
nuget install APIVerve.API.BMICalculator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.BMICalculator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.BMICalculator".
5. Click on the APIVerve.API.BMICalculator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the bmicalculator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The BMI Calculator API documentation is found here: [https://docs.apiverve.com/api/bmicalculator](https://docs.apiverve.com/api/bmicalculator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
BMI Calculator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new BMICalculatorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new BMICalculatorQueryOptions {
  weight = 70,
  height = 170,
  unit = "metric"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "height": "170 cm",
    "weight": "70 kg",
    "bmi": 24.221453287197235,
    "risk": "Low risk",
    "summary": "This weight is normal and you are healthy.",
    "recommendation": "A BMI between 18.5 and 24.9 falls within the 'normal' weight range according to the World Health Organization. This range is associated with the lowest health risk for conditions such as heart disease, diabetes, and certain cancers. However, it's important to note that BMI is not a perfect measure as it does not account for muscle mass, bone density, overall body composition, and racial and sex differences. Therefore, while it's a useful starting point, it should not be the only measure of one's health."
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.