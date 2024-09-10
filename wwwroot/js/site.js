function showInput() {
    // Hent værdierne fra inputfelterne
    var fromDate = document.getElementById('fromDate').value;
    var toDate = document.getElementById('toDate').value;
    var name = document.getElementById('nameTextBox').value;
    var email = document.getElementById('emailTextBox').value;

    // Vis værdierne i en alert
    alert("Hej " + name + "\nDu har booket fra: " + fromDate + " til: " + toDate + "\nPå denne email: " + email);
}