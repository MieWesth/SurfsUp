function showInput() {
    // Hent værdierne fra inputfelterne
    var fromDate = document.getElementById('fromDate').value;
    var toDate = document.getElementById('toDate').value;
    var name = document.getElementById('nameTextBox').value;
    var email = document.getElementById('emailTextBox').value;

    // Vis værdierne i en alert
    alert("Hej " + name + "\nDu har booket fra: " + fromDate + " til: " + toDate + "\nPå denne email: " + email);
}

//Modal Box <------------------->
function openModal(name, type, length, width, thickness, volume, price, imagePath) {
    document.getElementById('modalBoardName').textContent = name;
    document.getElementById('modalBoardType').textContent = type;
    document.getElementById('modalBoardLength').textContent = length;
    document.getElementById('modalBoardWidth').textContent = width;
    document.getElementById('modalBoardThickness').textContent = thickness;
    document.getElementById('modalBoardVolume').textContent = volume;
    document.getElementById('modalBoardPrice').textContent = price;
    document.getElementById('modalBoardImage').src = imagePath;

    // Show the modal
    document.getElementById('boardModal').style.display = 'block';
}

function closeModal() {
    document.getElementById('boardModal').style.display = 'none';
}

function bookBoard() {
    const dateFrom = document.getElementById('dateFrom').value;
    const dateTo = document.getElementById('dateTo').value;

    if (dateFrom && dateTo) {
        alert('Board booked from ' + dateFrom + ' to ' + dateTo + '!');
        closeModal();
    } else {
        alert('Please select both dates.');
    }
}

// Close the modal when clicking outside of it
window.onclick = function (event) {
    if (event.target == document.getElementById('boardModal')) {
        closeModal();
    }
}}