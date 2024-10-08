﻿// Function to open the modal and populate it with board data
function openModal(name, type, length, width, thickness, volume, price, equipment, imagePath, boardId, userId) {
    rentPrice = Math.round(price / 30);

    document.getElementById('modalBoardName').textContent = name;
    document.getElementById('modalType').textContent = type;
    document.getElementById('modalDimensions').textContent = `${length} x ${width} x ${thickness}`;
    document.getElementById('modalVolume').textContent = volume;
    document.getElementById('modalPrice').textContent = price;
    document.getElementById('modalRentPrice').textContent = rentPrice;
    document.getElementById("modal-board-id").value = boardId;
    document.getElementById("modal-user-id").value = userId;


    // Display "None" if equipment is null or empty
    document.getElementById('modalEquipment').textContent = equipment ? equipment : 'Intet';
    document.getElementById('modalImage').src = imagePath;

    document.getElementById('boardModal').style.display = 'block';
}
function closeModal() {
    document.getElementById('boardModal').style.display = 'none';
}

function openWetsuitModal(name, gender, size, thickness, price, imagePath, wetsuitId, userId,) {
    rentPrice = Math.round(price / 30);

    document.getElementById('modalWetsuitName').textContent = name;
    document.getElementById('modalGender').textContent = gender;
    document.getElementById('modalSize').textContent = size;
    document.getElementById('modalThickness').textContent = thickness;
    document.getElementById('modalPrice').textContent = price;
    document.getElementById('modalRentPrice').textContent = rentPrice;
    document.getElementById("modal-wetsuit-id").value = wetsuitId;
    document.getElementById("modal-user-id").value = userId;


    document.getElementById('modalImage').src = imagePath;
    document.getElementById('wetsuitModal').style.display = 'block';
}
function closeWetsuitModal() {
    document.getElementById('wetsuitModal').style.display = 'none';
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