function showInput() {
    // Hent værdierne fra inputfelterne
    var fromDate = document.getElementById('fromDate').value;
    var toDate = document.getElementById('toDate').value;
    var name = document.getElementById('nameTextBox').value;
    var email = document.getElementById('emailTextBox').value;

    // Vis værdierne i en alert
    alert("Book fra: " + fromDate + "\nBook til: " + toDate + "\nNavn: " + name + "\nEmail: " + email);
}