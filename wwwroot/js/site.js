// Function to open the modal and populate it with board data
function openModal(name, type, length, width, thickness, volume, price, equipment, imagePath) {
    rentPrice = Math.round(price / 30);
    document.getElementById('modalBoardName').textContent = name;
    document.getElementById('modalType').textContent = type;
    document.getElementById('modalDimensions').textContent = `${length} x ${width} x ${thickness}`;
    document.getElementById('modalVolume').textContent = volume;
    document.getElementById('modalPrice').textContent = price;
    document.getElementById('modalRentPrice').textContent = rentPrice;


    // Display "None" if equipment is null or empty
    document.getElementById('modalEquipment').textContent = equipment ? equipment : 'None';
    document.getElementById('modalImage').src = imagePath;

    document.getElementById('boardModal').style.display = 'block';
}

// Function to close the modal
function closeModal() {
    document.getElementById('boardModal').style.display = 'none';
}

// Function to handle board booking (you can expand this to save booking in the database)
function bookBoard() {
    const dateFrom = document.getElementById('dateFrom').value;
    const dateTo = document.getElementById('dateTo').value;

    if (!dateFrom || !dateTo) {
        alert('Vælg venligst begge datoer.');
        return;
    }

    alert(`Surfboard booket fra ${dateFrom} til ${dateTo}`);
    closeModal();
}

function login() {
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    if (!email && !password) {
        alert('Indtast venligst email og kodeord.');
        return;
    } else if (email && !password) {
        alert('Indtast venligst kodeord.');
        return;
    } else if (!email && password) {
        alert('Indtast venligst email.');
        return;
    } 
}