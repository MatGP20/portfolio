// import logo from './logo.svg';
import './App.css';
import '../node_modules/bootstrap/dist/css/bootstrap.css';

export default function NavBar() {
  return (
    <div className="App">
      <div class="sticky-top" data-spy="scroll" data-target="#menu-navegacion">
        <nav class="navbar navbar-expand-md text-bg-secondary fst-light" id="menu-navegacion">
            <a class="navbar-brand ms-5 fs-1 text-light" href="#">Matias Palacio</a>
            <button class="navbar-toggler me-5 fs-4" type="button" data-toggle="collapse" data-target="#navbarMarkup"
                aria-controls="navbarMarkup" aria-expanded="false" aria-label="Toggle navigation">MENU
            </button>
            <div class="collapse navbar-collapse" id="navbarMarkup">
                <div class="navbar-nav mx-auto">
                    <PageLink link = {{reference: '#SobreMi', name: 'Sobre Mi'}}/>
                    <PageLink link = {{reference: '#Skill', name: 'Skill'}}/>
                    <PageLink link = {{reference: '#Proyectos', name: 'Proyectos'}}/>
                    <PageLink link = {{reference: '#Contacto', name: 'Contacto'}}/>
                </div>
            </div>
        </nav>
      </div>
    </div>

  );
}

export function PageLink({link}){
  return (
    <div>
      <a class="nav-link fs-5" href={link.reference}>{link.name}</a>  
    </div>
  );
}
