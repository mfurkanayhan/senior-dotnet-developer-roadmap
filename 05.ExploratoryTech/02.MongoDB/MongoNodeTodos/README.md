## Getting Started

Follow these steps to get the project running on your local machine.

### Prerequisites

You need to have Node.js and MongoDB installed on your computer to run this project.

### Installation

1. Create a new directory on your computer where you want the project to reside.

2. Navigate to the created directory:

   ```bash
    cd path_to_your_directory
   ```
3. Create the necessary files manually. You will need at least the following files:

- **\`index.html`**: The HTML file for the user interface.
- **\`index.js:`** The Node.js server file.

4. Populate `index.html` and `index.js` with the code from the project or write your own.

5. Install the required packages:
```bash
npm init -y
npm install express cors mongoose
```
6. Start the server
```bash
node index.js
```

### Usage

Open your browser and navigate to `http://localhost:7000/`. You can add new tasks, update existing ones, or delete them through the application interface.

## API Endpoints

- **\`GET /api/getAll`** : Lists all TODOs.
- **\`POST /api/save`** : Saves a new TODO.
- **\`POST /api/update`** : Updates an existing TODO.
- **\`POST /api/removeById`** : Deletes a TODO.