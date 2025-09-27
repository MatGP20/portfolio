function startCarrousel() {
    setTimeout(function () {
        const btn = document.getElementById("nextButton");
        if (btn) {
            btn.click();
        }
    }, 5000);
};


function autoRealScroll(bloque) {
    if (typeof bloque !== 'string') {
        console.error('autoScroll() recibió un valor inválido:', bloque);
        console.trace();
        return;
    }
    const el = document.querySelector(bloque);
    if (!el) return;

    let pause = false;
    let scrolling = false;
    let ciclos = 0;
    const maxCiclos = 4;
    const threshold = 20; 

    const scroll = () => {
        if (pause || ciclos >= maxCiclos) return;

        const maxScroll = el.scrollHeight - el.clientHeight;
        const current = el.scrollTop;

        if (current + threshold < maxScroll) {
            el.scrollBy(0, 1);
            requestAnimationFrame(scroll);
        } else {
            ciclos++;
            el.scrollTo({ top: 0, behavior: 'auto' });

            setTimeout(() => {
                if (!pause && ciclos < maxCiclos) {
                    requestAnimationFrame(scroll);
                }
            }, 500);
        }
    };

    const init = () => {
        if (el.scrollHeight <= el.clientHeight || scrolling) return;
        scrolling = true;

        el.addEventListener('mouseenter', () => pause = true);
        el.addEventListener('mouseleave', () => {
            pause = false;
            if (!scrolling && ciclos < maxCiclos) {
                scrolling = true;
                requestAnimationFrame(scroll);
            }
        });

        requestAnimationFrame(scroll);
    };

    setTimeout(init, 5000);
};