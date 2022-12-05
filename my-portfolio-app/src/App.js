// import logo from './logo.svg';
import './App.css';
import '../node_modules/bootstrap/dist/css/bootstrap.css';

export default function App() {
  return (
    <div className="App">
      <div class="sticky-top" data-spy="scroll" data-target="#menu-navegacion">
        <nav class="navbar navbar-expand-md text-bg-secondary fst-light" id="menu-navegacion">
            <a class="navbar-brand" href="#">Matias Palacio</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarMarkup"
                aria-controls="navbarMarkup" aria-expanded="false" aria-label="Toggle navigation">MENU
            </button>
            <div class="collapse navbar-collapse" id="navbarMarkup">
                <div class="navbar-nav mx-auto">
                    <a class="nav-link active" href="#sobre-mi">Sobre mí</a>
                    <a class="nav-link" href="#skills">Skills</a>
                    <a class="nav-link" href="#portfolio">Portfolio</a>
                    <a class="nav-link" href="#contacto">Contacto</a>
                </div>
            </div>
        </nav>
      </div>
    </div>
  );
}


