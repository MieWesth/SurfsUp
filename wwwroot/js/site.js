function showInput() {
    // Hent værdierne fra inputfelterne
    var fromDate = document.getElementById('fromDate').value;
    var toDate = document.getElementById('toDate').value;
    var name = document.getElementById('nameTextBox').value;
    var email = document.getElementById('emailTextBox').value;

    // Vis værdierne i en alert
    alert("Hej " + name + "\nDu har booket fra: " + fromDate + " til: " + toDate + "\nPå denne email: " + email);
}
// Sample CSV data
const csvData = `
The Minilog;6;21;2.75;38.8;Shortboard;565;
The Wide Glider;7.1;21.75;2.75;44.16;Funboard;685;
The Golden Ratio;6.3;21.85;2.9;43.22;Funboard;695;
Mahi Mahi;5.4;20.75;2.3;29.39;Fish;645;
The Emerald Glider;9.2;22.8;2.8;65.4;Longboard;895;
The Bomb;5.5;21;2.5;33.7;Shortboard;645;
Walden Magic;9.6;19.4;3;80;Longboard;1025;
Naish One;12.6;30;6;301;SUP;854;Paddle;
Six Tourer;11.6;32;6;270;SUP;611;Fin, Paddle, Pump, Leash;
Naish Maliko;14;25;6;330;SUP;1304;Fin, Paddle, Pump, Leash;
`;

// Parse CSV data and convert to objects
function parseCSV(data) {
    const rows = data.trim().split('\n');
    const headers = ["name", "length", "width", "thickness", "volume", "type", "price", "equipment", "id", "image"];

    return rows.map((row, index) => {
        const values = row.split(';');
        return {
            [headers[0]]: values[0],
            [headers[1]]: values[1],
            [headers[2]]: values[2],
            [headers[3]]: values[3],
            [headers[4]]: values[4],
            [headers[5]]: values[5],
            [headers[6]]: values[6],
            [headers[7]]: values[7] || '',
            [headers[8]]: `${index + 1}`, // Generate a unique ID
            [headers[9]]: `/Images/surfboard-${index + 1}.jpg` // Generate an image path
        };
    });
}

// Display parsed data in HTML using the provided CSS classes
function displaySurfboards(surfboards) {
    const container = document.getElementById('surfboard-list');
    surfboards.forEach(surfboard => {
        // Create anchor element for clickable card

            const card = document.createElement('a');
            card.classList.add('card'); // Use the 'card' class
            card.href = `/../../Bookings/index/${surfboard.id}`; // Use '#' or set a specific URL for each item
            card.style.textDecoration = 'none'; // Remove underline from link

            // Image container
            const imageContainer = document.createElement('div');
            imageContainer.classList.add('image-container'); // Use the 'image-container' class

            const img = document.createElement('img');
            img.src = surfboard.image;
            img.alt = surfboard.name;
            img.classList.add('image'); // Use the 'image' class
            imageContainer.appendChild(img);

            // Text container for name
            const textContainer = document.createElement('div');
            textContainer.classList.add('text-container'); // Use the 'text-container' class

            const name = document.createElement('span');
            name.textContent = surfboard.name;
            textContainer.appendChild(name);

            // Text container for type
            const typeContainer = document.createElement('div');
            typeContainer.classList.add('text-container-type'); // Use the 'text-container-type' class

            const type = document.createElement('span');
            type.textContent = surfboard.type;
            typeContainer.appendChild(type);

            // Append elements to card (anchor)
            card.appendChild(imageContainer);
            card.appendChild(textContainer);
            card.appendChild(typeContainer);

            // Append card to container
            container.appendChild(card);
        
    });
}

// Execute functions to parse CSV and display surfboards
const surfboards = parseCSV(csvData);
displaySurfboards(surfboards);