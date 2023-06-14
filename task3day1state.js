

        
         
      
    function calculateAge() {
        var dob = document.getElementById("dob").value;
        var today = new Date();
        var birthDate = new Date(dob);
        var age = today.getFullYear() - birthDate.getFullYear();
        var monthDiff = today.getMonth() - birthDate.getMonth();
        
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        
        document.getElementById("age").value = age;
    }

    // Attach the calculateAge function to the "change" event of the date input
    document.getElementById("dob").addEventListener("change", calculateAge);
function populateCities() {
    var stateDropdown = document.getElementById("state");
    var cityDropdown = document.getElementById("city");
    var selectedState = stateDropdown.value;

    // Clear existing options
    cityDropdown.innerHTML = "";

    // Add options based on selected state
    if (selectedState === "Andaman and Nicobar Islands") {
        var cities = ["Port Blair", "Car Nicobar", "Havelock Island"];
    } else if (selectedState === "Andhra Pradesh") {
        var cities = ["Hyderabad", "Visakhapatnam", "Vijayawada", "Guntur", "Tirupati"];
    } else if (selectedState === "Arunachal Pradesh") {
        var cities = ["Itanagar", "Naharlagun", "Pasighat", "Tawang", "Ziro"];
    } else if (selectedState === "Assam") {
        var cities = ["Guwahati", "Jorhat", "Silchar", "Dibrugarh", "Tezpur"];
    }
    else if (selectedState === "Bihar") {
        var cities = ["Patna", "Gaya", "Muzaffarpur", "Bhagalpur", "Darbhanga"];
    } else if (selectedState === "Chandigarh") {
        var cities = ["Chandigarh"];
    } else if (selectedState === "Chhattisgarh") {
        var cities = ["Raipur", "Bhilai", "Bilaspur", "Korba", "Durg"];
    } else if (selectedState === "Delhi") {
        var cities = ["New Delhi", "Gurgaon", "Noida", "Faridabad", "Ghaziabad"];
    } else if (selectedState === "Goa") {
        var cities = ["Panaji", "Margao", "Vasco da Gama", "Mapusa", "Ponda"];
    }else if (selectedState === "Gujarat") {
        var cities = ["Ahmedabad", "Surat", "Vadodara", "Rajkot", "Bhavnagar", "Jamnagar", "Junagadh", "Gandhinagar", "Anand", "Navsari"];
    } else if (selectedState === "Haryana") {
        var cities = ["Gurgaon", "Faridabad", "Panipat", "Ambala", "Yamunanagar", "Rohtak", "Hisar", "Karnal", "Sonipat", "Panchkula"];
    } else if (selectedState === "Himachal Pradesh") {
    var cities = ["Shimla", "Manali", "Dharamshala", "Kullu", "Mandi"];
    } else if (selectedState === "Jammu and Kashmir") {
    var cities = ["Srinagar", "Jammu", "Leh", "Gulmarg", "Pahalgam"];
    } else if (selectedState === "Jharkhand") {
    var cities = ["Ranchi", "Jamshedpur", "Dhanbad", "Bokaro", "Hazaribagh"];
    } else if (selectedState === "Karnataka") {
    var cities = ["Bangalore", "Mysore", "Hubli", "Mangalore", "Belgaum"];
    } else if (selectedState === "Kerala") {
    var cities = ["Thiruvananthapuram", "Kochi", "Kozhikode", "Thrissur", "Kollam"];
    } else if (selectedState === "Tamil Nadu") {
    var cities = ["Chennai", "Coimbatore", "Madurai", "Trichy", "Salem"];
    }
    // Add more else if statements for each state and its corresponding cities

    for (var i = 0; i < cities.length; i++) {
        var option = document.createElement("option");
        option.text = cities[i];
        option.value = cities[i];
        cityDropdown.add(option);
    }
}