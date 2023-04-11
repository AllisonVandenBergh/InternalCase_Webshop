type RequestOptions = {
  method: "GET" | "POST" | "PUT" | "DELETE";
  url: string;
  data?: unknown;
};

class RequestError extends Error {
  constructor(message: string, statusCode?: number) {
    super(message);
    this.name = "RequestError";
  }
}

export const request = async <TResponse>({ method, url, data }: RequestOptions): Promise<TResponse> => {
  const response = await fetch(url, {
    method: method,
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  });

  if (!response.ok) {
    // const json = await response.json();
    throw new RequestError(response.statusText);
  }

  return response.statusText === "No Content" ? response : response.json();
};