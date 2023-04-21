var settings = {
    "url": "https://xn--nskeportalen-ujb.dk/api/AboutUs.json",
    "method": "GET",
    "timeout": 0,
    "headers": {
        "Cookie": "csrfToken=gu4vyaZiDJUH1qu0aiC95TAzZWYzNjUyNjAzNGFhNzliNjliZjk5Yzk5YzRhNjQwOGM3MWFmYWI%3D"
    },
};

$.ajax(settings).done(function (response) {
    console.log(response);
});