<h1>Doofus Run</h1>
<p>Doofus Run is a tile-hopping survival game built in Unity. The player controls a cube that must keep moving onto newly spawned tiles before the current one disappears. Time your movement, react fast, and survive as long as possible.</p>

<hr/>

<h2>🎮 Gameplay</h2>
<ul>
  <li>The game begins on a single tile.</li>
  <li>Every few seconds, a <strong>new tile spawns</strong> adjacent to the current one.</li>
  <li>Each tile has a <strong>random lifetime</strong> after which it disappears.</li>
  <li>Standing on a vanishing tile results in <strong>falling and game over</strong>.</li>
  <li>Each new tile successfully landed on increases your <strong>score by +1</strong>.</li>
  <li>The objective: <strong>survive and score as high as possible</strong>.</li>
</ul>

<hr/>

<h2>🕹 Controls</h2>
<table>
  <tr><th>Key</th><th>Action</th></tr>
  <tr><td>W</td><td>Move forward</td></tr>
  <tr><td>S</td><td>Move backward</td></tr>
  <tr><td>A</td><td>Move left</td></tr>
  <tr><td>D</td><td>Move right</td></tr>
</table>
<p>Movement is physics-based using Unity’s Rigidbody system.</p>

<hr/>

<h2>🧩 Key Systems</h2>

<h3>PlayerMovement</h3>
<p>Handles:</p>
<ul>
  <li>Keyboard input</li>
  <li>Rigidbody movement</li>
  <li>Fall detection</li>
  <li>Game over triggers</li>
</ul>

<h3>TileSpawner</h3>
<p>Responsible for:</p>
<ul>
  <li>Spawning next tiles</li>
  <li>Ensuring adjacency</li>
  <li>Using timing values from JSON config</li>
</ul>

<h3>Tile</h3>
<p>Manages:</p>
<ul>
  <li>Tile lifetime</li>
  <li>Random destruction time</li>
  <li>Visual feedback</li>
  <li>LeanTween shrink animation upon death</li>
</ul>

<h3>GameConfig (JSON-driven)</h3>
<p>Reads game settings from:</p>
<code>StreamingAssets/doofus_diary.json</code>

<p>Example JSON:</p>
<pre>
{
   "player_data" : {
     "speed" : 3
   },
   "pulpit_data" : {
     "min_pulpit_destroy_time" : 4,
     "max_pulpit_destroy_time" : 5,
     "pulpit_spawn_time" : 2.5
   }
}
</pre>

<p>This enables easy external balancing without changing code.</p>

<hr/>

<h2>🎨 Visual & UX Features</h2>
<ul>
  <li>Tile countdown display using TextMeshPro</li>
  <li>Smooth camera follow</li>
  <li>Tile death animation:
    <ul>
      <li>slight pop-expand</li>
      <li>followed by shrink to zero</li>
    </ul>
  </li>
  <li>Audio effects:
    <ul>
      <li>pop on spawn</li>
      <li>crack/fall sounds on death</li>
    </ul>
  </li>
  <li>Clean UI:
    <ul>
      <li>Start screen</li>
      <li>Game over screen</li>
      <li>Score display</li>
    </ul>
  </li>
</ul>

<hr/>

<h2>🧠 Code Quality Philosophy</h2>
<ul>
  <li>Modular components (single-responsibility)</li>
  <li>JSON-driven gameplay config</li>
  <li>Expandable & maintainable architecture</li>
  <li>LeanTween used for animation polish</li>
  <li>No god-objects, no tangled logic</li>
</ul>

<hr/>

<h2>📦 Dependencies</h2>
<ul>
  <li>Unity 2022+</li>
  <li>TextMeshPro</li>
  <li>LeanTween</li>
</ul>

<hr/>

<h2>🚀 Running the Game</h2>
<ol>
  <li>Clone the repo</li>
  <li>Open the project in Unity</li>
  <li>Ensure <code>StreamingAssets/doofus_diary.json</code> exists</li>
  <li>Press Play and enjoy!</li>
</ol>

<hr/>

<h2>🧪 Future Improvements</h2>
<ul>
  <li>Multiple tile types</li>
  <li>Difficulty scaling over time</li>
  <li>Power-ups (speed boost / freeze decay)</li>
  <li>Online leaderboard</li>
  <li>Mobile touch movement controls</li>
  <li>Better visual FX on tile death</li>
</ul>

<hr/>

<h2>👨‍💻 Developer Notes</h2>
<p>This project was created as a prototype to explore:</p>
<ul>
  <li>JSON-driven game tuning</li>
  <li>Modular Unity architecture</li>
  <li>Procedural tile adjacency spawning</li>
  <li>Gameplay clarity through animation and subtle feedback</li>
</ul>
<p>It’s lightweight, extensible, and built to be iterated on.</p>

<hr/>

<h2>📄 License</h2>
<p>MIT — do whatever you want with the code. Attribution appreciated but not required.</p>

<hr/>

<p>If you have suggestions or improvements — PRs are welcome!</p>



https://github.com/user-attachments/assets/dc5baf0e-aeaf-44b7-8b22-7561d9ebc58e
